using Euresys.Open_eVision_22_12.Easy3D;
using Euresys.Open_eVision_22_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;

namespace ZmapGenerator
{
    public partial class MainForm : Form
    {
        // 3D Viewer
        private E3DViewer sourceViewer_3D = null;
        private float m_minDistanceToObjects = 20;
        // 2D Viewer
        private EImageBW8 image_ = null;
        private EImageC24 image_C24 = null;
        private int imageWidth_;
        private int imageHeight_;
        private float zoomFactor_ = 1;
        private string fileName = string.Empty;
        int m_Dragging;     // 0 means no dragging, 1 means dragging the image, 2 means dragging a region handle

        // Reference
        private bool referenceAsPointCloud_;
        private EPointCloud referencePointCloud_ = null;

        private bool referenceAsMesh_;
        private EMesh referenceMesh_ = null;
        private E3DObjectExtractor extractor_ = null;
        // ZMap
        private EZMap generatedZMap_ = null;
        private EZMap16 generatedZMap_16 = null;
        private EZMap16 EZMap16_ = null;
        private EZMap ZMap_3D = null;

        //縮放尺寸
        private float scale = 1.0f;
        private bool isMouseOverPanel = false;
        private Point mouseDownLocation;
        private Point imageLocation;
        private ERegion objRegion = null;

        //ObjectListview
        List<E3DObject> List_E3DObject = new List<E3DObject>();

        //ROI
        ERectangleRegion m_RectRegion = new ERectangleRegion();

        int selectedItem = new int();

        private ListViewItemComparer listViewItemComparer;

        public MainForm()
        {   
            InitializeComponent();
            m_Dragging = 0;
            this.DoubleBuffered = true;
            //this.zmapViewerWindow.MouseWheel += ImagePanel_MouseWheel;
            //this.zmapViewerWindow.MouseEnter += ImagePanel_MouseEnter;
            //this.zmapViewerWindow.MouseLeave += ImagePanel_MouseLeave;

            this.pictureBox1.MouseWheel += PictureBox_MouseWheel;
            this.pictureBox1.MouseEnter += PictureBox_MouseEnter;
            this.pictureBox1.MouseLeave += PictureBox_MouseLeave;

            listViewItemComparer = new ListViewItemComparer();
            this.ObjlistView.ListViewItemSorter = listViewItemComparer;
        }

        /// <summary>
        /// 初始化3D視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //sourceViewer_3D = new E3DViewer(0, 0,sourceViewerWindow.Width, sourceViewerWindow.Height, (IntPtr)sourceViewerWindow.Handle);
                //sourceViewer_3D.InitRendering();
                //ERGBColor background = new ERGBColor(0, 0, 0);
                //sourceViewer_3D.BackgroundColor = background;
                //ERGBColor axisgraduationcolor = new ERGBColor(90, 90, 90);
                //using (E3DAxisDisplay axisDisplay = sourceViewer_3D.RenderAxisConfiguration)
                //    axisDisplay.AxisGraduationColor = axisgraduationcolor;
                //EC24 pickinglabelcolor = new EC24(255, 255, 255);
                //sourceViewer_3D.PickingLabelColor = pickinglabelcolor;

                //sourceViewer_3D.Show();
                sourceViewer_3D = new E3DViewer(0, 0, pictureBox_3D.Width, pictureBox_3D.Height, (IntPtr)pictureBox_3D.Handle);
                sourceViewer_3D.InitRendering();
                ERGBColor background = new ERGBColor(0, 0, 0);
                sourceViewer_3D.BackgroundColor = background;
                ERGBColor axisgraduationcolor = new ERGBColor(90, 90, 90);
                using (E3DAxisDisplay axisDisplay = sourceViewer_3D.RenderAxisConfiguration)
                    axisDisplay.AxisGraduationColor = axisgraduationcolor;
                EC24 pickinglabelcolor = new EC24(255, 255, 255);
                sourceViewer_3D.PickingLabelColor = pickinglabelcolor;

                sourceViewer_3D.Show();
                sourceViewer_3D.SetFocus();


                referenceMesh_ = new EMesh();
                
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //InitListView();
        }

        /// <summary>
        /// 載入PointCloud並轉成Zmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objectclear();
            // Show open file dialog
            referencePointCloud_ = new EPointCloud();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // get the selected path
                string pathS = openFileDialog1.FileName;
                fileName = Path.GetFileNameWithoutExtension(pathS);

                // try mesh then point cloud
                referenceAsMesh_ = false;
                referenceAsPointCloud_ = false;
                try
                {
                    referenceAsMesh_ = true;
                    referenceMesh_.Load(pathS);
                }
                catch (EException)
                {
                    referenceAsMesh_ = false;
                }

                if (!referenceAsMesh_)
                {
                    referenceAsPointCloud_ = true;
                    try
                    {
                        referencePointCloud_.Load(pathS);
                        //var numbers = referencePointCloud_.NumPoints;
                    }
                    catch (EException)
                    {
                        referenceAsPointCloud_ = false;
                    }
                }
                if (!referenceAsMesh_ && !referenceAsPointCloud_)
                {
                    MessageBox.Show("No suitable Mesh or Point Cloud format found to read the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
           
            try
            {
                GenerateZmap2();

                SuggestObjectValue();
            }
            catch(EException exc)
            {
                MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Refresh the form
            Refresh();

        }
        private void GenerateZmap2()
        { 
            EZMap16 eZMap16 = new EZMap16();
            EZMap16 filteredZmap = new EZMap16();
            if (referenceAsMesh_)
            {
                EMeshToZMapConverter MMeshtoZMap = new EMeshToZMapConverter();
                MMeshtoZMap.SetMapXYResolution((float)0.1, 0.1f);


                MMeshtoZMap.Convert(referenceMesh_, eZMap16);

                EZMapToMeshConverter ZMaptoMesh = new EZMapToMeshConverter();
                ZMaptoMesh.Convert(eZMap16, referenceMesh_);  //建立出的Zmap空間的Mesh

            }
            else if (referenceAsPointCloud_)
            {
                EPointCloudToZMapConverter pctozmap = new EPointCloudToZMapConverter();
                //pctozmap.SetMapSize(3200, 2500);
                pctozmap.SetMapXYResolution((float)0.1, 0.1f);


                //pctozmap.SetFillMode(EFillUndefinedPixelsDirection.Vertical, EFillUndefinedPixelsMethod.KeepMinimum);

                pctozmap.Convert(referencePointCloud_, eZMap16);


                //---------------------------------------------中位數濾波
                
                //filteredZmap.SetSize(eZMap16);

                //EFilters.RemoveNoise(eZMap16, filteredZmap, ENoiseRemovalMethod.HighStandardDeviation, 3, 30.0F, 0.0F);
                //----------------------------------------------鄰近推倒濾波
                //EZMap16 averagedZMap = new EZMap16();
                //averagedZMap.SetSize(eZMap16);
                //EStatistics.ComputeAverageMap(eZMap16, averagedZMap, 3, 0.2F);
                //EFilters.RemoveNoise(averagedZMap, filteredZmap, ENoiseRemovalMethod.AbsoluteDifferenceFromMean, 15, 20.0F, 0.2F);


                EZMapToPointCloudConverter zmaptopc = new EZMapToPointCloudConverter();
                zmaptopc.Convert(eZMap16, referencePointCloud_, true);  //建立出的Zmap空間的PointCloud

                
            }
           
            if (generatedZMap_ != null)
            {
                generatedZMap_.Dispose();
                generatedZMap_ = null;
            }

            bool isZMap8 = false;
            bool isZMap16 = true;

            //if (isZMap8)
            //    generatedZMap_ = new EZMap8();
            //else if (isZMap16)
            //    generatedZMap_ = new EZMap16();

            generatedZMap_ = new EZMap16();

            image_ = new EImageBW8();
            image_C24 = new EImageC24();

            if (isZMap8)
            {
                //generatedZMap_ = eZMap16;
                //image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                //using (EImageBW8 tmp = ((EZMap8)generatedZMap_).AsEImage())
                //    EasyImage.Copy(tmp, image_);
            }
            else if (isZMap16)
            {
                generatedZMap_ = eZMap16;
                image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                using (EImageBW16 tmp = ((EZMap16)generatedZMap_).AsEImage())
                {
                    EasyImage.Convert(tmp, image_);
                    //EasyImage.Convert(image_, image_C24);
                }
            }

            try
            {
                //3DViewer根據剛剛從Zmap建立的PD空間(referencePointCloud_)當作參照
                sourceViewer_3D.RemoveAllRenderSources();
                if (referenceAsPointCloud_)
                {
                    sourceViewer_3D.AddRenderSource("Reference", referencePointCloud_);
                }
                else if (referenceAsMesh_)
                {
                    sourceViewer_3D.AddRenderSource("Reference", referenceMesh_);
                }

                sourceViewer_3D.SetRenderSourceColorMode("Reference", ESourceColorMode.Ramp);
                sourceViewer_3D.ResetView();
                sourceViewer_3D.SetFocus();
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitRegions();
            Refresh();
        }


        /// <summary>
        /// 將Z軸作為投射軸，轉換為EZMap16，再轉換為PointCloud，統一3D與ZMap座標。
        /// </summary>
        private void GenerateZmap()
        {
            try
            {   
                //轉換方法1：視角、參照平面轉換
                //    //取得所有參數
                //    float zmapExtension = 0;
                //    E3DPoint res;
                //    res.X = 0;
                //    res.Y = 0;
                //    res.Z = 0;
                //    int zmapSizeX = 0;
                //    int zmapSizeY = 0;

                //    // 取得 view matrix
                //    E3DTransformMatrix view_matrix = new E3DTransformMatrix();
                //    sourceViewer_3D.GetRotationMatrix(view_matrix);
                //    view_matrix = view_matrix.Transpose();  
                //    //將視角的旋轉矩陣轉換為pose方向矩陣
                //    // world->view to view->world

                //    // 設定參照平面
                //    E3DPlane refPlane = new E3DPlane();

                //    E3DPoint normal;
                //    normal.X = 0;
                //    normal.Y = 0;
                //    normal.Z = 0;
                //    float signedDist = 0;

                //    if (normal.X == 0.0f && normal.Y == 0.0f && normal.Z == 0.0f && signedDist == 0.0f)
                //        normal.Z = 1.0f;  

                //    refPlane.Normal = normal;
                //    refPlane.SignedDistanceFromOrigin = signedDist;

                //    bool setExplicitlyOrientationVector = true;
                //    E3DPoint orientationVector;

                //    orientationVector.X = 0;
                //    orientationVector.Y = 0;
                //    orientationVector.Z = 0;

                //    if (orientationVector.X == 0.0f && orientationVector.Y == 0.0f && orientationVector.Z == 0.0f)
                //        setExplicitlyOrientationVector = false;  

                //    view_matrix.Dispose();

                //    if (generatedZMap_ != null)
                //    {
                //        generatedZMap_.Dispose();
                //        generatedZMap_ = null;
                //    }
                //    //generatedZMap_ = new EZMap8();
                //    bool isZMap8 = false;
                //    bool isZMap16 = true;

                //    if (isZMap8)
                //        generatedZMap_ = new EZMap8();
                //    else if (isZMap16)
                //        generatedZMap_ = new EZMap16();

                //    // draw plane
                //    if (sourceViewer_3D.HasRenderSource("plane"))
                //        sourceViewer_3D.RemoveRenderSource("plane");

                //    sourceViewer_3D.AddRenderSource("plane", refPlane, new EC24(128, 128, 128), 128);

                //    // 建立轉換器生成ZMap

                //    using (EPointCloudToZMapConverter converter = new EPointCloudToZMapConverter())
                //    {
                //        converter.Extension = zmapExtension;

                //        if (res.X != 0.0f && res.Y != 0.0f)converter.SetMapXYResolution(res.X, res.Y);

                //        if (res.Z != 0.0f)converter.MapZResolution = res.Z;

                //        if (zmapSizeX != 0 && zmapSizeY != 0)converter.SetMapSize(zmapSizeX, zmapSizeY);

                //        converter.ReferencePlane = refPlane;
                //        refPlane.Dispose();

                //        converter.EnableFillMode(false);

                //        if (setExplicitlyOrientationVector)
                //            converter.OrientationVector = orientationVector;
                //        try
                //        {
                //            converter.Convert(referencePointCloud_, generatedZMap_);
                //        }
                //        catch (EException exc)
                //        {
                //            MessageBox.Show("Error when generating ZMap: " + exc.What() + ", please check input parameters.",
                //                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            return;
                //        }
                //    }

                //轉換方法2：先將PD轉換為EZMap16，再轉換為PointCloud，統一3D與ZMap座標。

                EZMap16 eZMap16 = new EZMap16();
                EPointCloudToZMapConverter pctozmap = new EPointCloudToZMapConverter();


                pctozmap.SetMapSize(3200, 2500);
                pctozmap.SetMapXYResolution((float)0.1, 0.1f);

                
                pctozmap.SetFillMode(EFillUndefinedPixelsDirection.Vertical, EFillUndefinedPixelsMethod.KeepMinimum);

                pctozmap.Convert(referencePointCloud_, eZMap16);

                EZMapToPointCloudConverter zmaptopc = new EZMapToPointCloudConverter();
                zmaptopc.Convert(eZMap16, referencePointCloud_, true);  //建立出的Zmap空間的PointCloud

                if (generatedZMap_ != null)
                {
                    generatedZMap_.Dispose();
                    generatedZMap_ = null;
                }
                
                bool isZMap8 = false;
                bool isZMap16 = true;

                //if (isZMap8)
                //    generatedZMap_ = new EZMap8();
                //else if (isZMap16)
                //    generatedZMap_ = new EZMap16();

                generatedZMap_ = new EZMap16();

                image_ = new EImageBW8();
                image_C24 = new EImageC24();

                if (isZMap8)
                {
                    //generatedZMap_ = eZMap16;
                    //image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                    //using (EImageBW8 tmp = ((EZMap8)generatedZMap_).AsEImage())
                    //    EasyImage.Copy(tmp, image_);
                }
                else if (isZMap16)
                {
                    generatedZMap_ = eZMap16;
                    image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                    using (EImageBW16 tmp = ((EZMap16)generatedZMap_).AsEImage())
                    {
                        EasyImage.Convert(tmp, image_);
                        //EasyImage.Convert(image_, image_C24);
                    }
                        
                }

                try
                {
                    //3DViewer根據剛剛從Zmap建立的PD空間(referencePointCloud_)當作參照
                    sourceViewer_3D.RemoveAllRenderSources();
                    if (referenceAsPointCloud_)
                    {
                        sourceViewer_3D.AddRenderSource("Reference", referencePointCloud_);
                    }
                    else if (referenceAsMesh_)
                    {
                        sourceViewer_3D.AddRenderSource("Reference", referenceMesh_);
                    }

                    sourceViewer_3D.SetRenderSourceColorMode("Reference", ESourceColorMode.Ramp);
                    sourceViewer_3D.ResetView();
                    sourceViewer_3D.SetFocus();
                }
                catch (EException exc)
                {
                    MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (EException exc)
            {
                MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("one of the fields you filled contains something that is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitRegions();
            Refresh();
        }
        private void InitRegions()
        {
            float width = generatedZMap_.Width;
            float height = generatedZMap_.Height;

            m_RectRegion = new ERectangleRegion(0.25f * width, 0.25f * height, 0.5f * width, 0.5f * height);

        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

            if (sourceViewer_3D != null)
                sourceViewer_3D.SetPosition(0, 0, control.Size.Width, control.Size.Height, (IntPtr)1); // 1 for bottom order of the Z-buffer
        }
        /// <summary>
        /// 繪製2DZmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zmapViewerWindow_Paint(object sender, PaintEventArgs e)
        {
            ////Prepare double buffering
            //BufferedGraphicsContext currentContext;
            //BufferedGraphics myBuffer;

            //currentContext = BufferedGraphicsManager.Current;

            //// Create background
            //Rectangle background = zmapViewerWindow.DisplayRectangle;
            //myBuffer = currentContext.Allocate(zmapViewerWindow.CreateGraphics(), background);
            //myBuffer.Graphics.FillRectangle(new SolidBrush(Color.White), background);

            //// Draw the eVision Objects into the buffer
            //try
            //{
            //    if (image_.IsVoid)// If image is empty, exit
            //    {
            //        return;
            //    }
            //    image_.Draw(myBuffer.Graphics, zoomFactor_ * scale, zoomFactor_ * scale, 0.0f, 0.0f);
            //}
            //catch (EException exc)
            //{
            //    if (exc.Error != EError.LicenseMissing)
            //    {
            //        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            ////Render the buffer
            //myBuffer.Render();
            //myBuffer.Dispose();
            
        }



        private void btn_objextract_Click(object sender, EventArgs e)
        {
            Extract3DObjects();
            Setup3DObjectView();
            UpdateViewer();
            InitListView();
        }
        
        private void Extract3DObjects()
        {
            try
            {
                
                E3DPoint resolution = generatedZMap_.GetResolution();

                extractor_.LengthRange = new EFloatRange(float.Parse(txt_Length_from.Text), float.Parse(txt_Length_to.Text));
                extractor_.WidthRange = new EFloatRange(float.Parse(txt_Width_from.Text), float.Parse(txt_Width_to.Text));

                extractor_.LocalHeightRange = new EFloatRange(float.Parse(txt_Local_height_from.Text), float.Parse(txt_Local_height_to.Text));
                extractor_.ReferenceHeightRange = new EFloatRange(float.Parse(txt_Refrence_height_from.Text), float.Parse(txt_Refrence_height_to.Text));

                // object orientation
                extractor_.OrientationRange = new EFloatRange(float.Parse(txt_Orientation_from.Text), float.Parse(txt_Orientation_to.Text));

                // object tilt
                extractor_.ReferenceTiltRange = new EFloatRange(float.Parse(txt_Refrence_tilt_from.Text), float.Parse(txt_Refrence_tilt_to.Text));
                extractor_.LocalTiltRange = new EFloatRange(float.Parse(txt_Loacl_tilt_from.Text), float.Parse(txt_Loacl_tilt_to.Text));

                // aspect ratio
                extractor_.AspectRatioRange = new EFloatRange(float.Parse(txt_Aspect_ratio_from.Text), float.Parse(txt_Aspect_to.Text));

                // object area
                extractor_.AreaRange = new EFloatRange(float.Parse(txt_Area_from.Text), float.Parse(txt_Area_to.Text));

                // object volume
                extractor_.VolumeRange = new EFloatRange(float.Parse(txt_Volume_from.Text), float.Parse(txt_Volume_to.Text));

                extractor_.ContourReinforce = cbContourReinforce.Checked;

                extractor_.SetComputeFeature(E3DObjectFeature.Sphere, checkBox_Spherefitting.Checked);
                // do the extraction
                extractor_.Extract(generatedZMap_);//取得3D物件(object)

                List_E3DObject = extractor_.Objects.ToList();//將物件(object)存放至List
                if (List_E3DObject.Count == 0) return;
                E3DPlane Eplane = List_E3DObject[0].Plane;
                var SignedDistanceFromOrigin_ = Eplane.SignedDistanceFromOrigin;
                var Normal = Eplane.Normal;

                //var value = List_E3DObject[0].AveragePosition;

                //E3DBox e3DBox = new E3DBox();
                //e3DBox.XSize = 10;

                ////--------------------------------------------------------------------------------------------------------
                ////var bbx = List_E3DObject[0].BoundingBox;
                ///

                //objRegion = new ERegion();
                //objRegion = List_E3DObject[0].Region;


                //E3DPoint center = new E3DPoint();

                //for (int i = 0; i < List_E3DObject.Count; i++)
                //{
                //    if (List_E3DObject[i].AveragePosition.X < 131)
                //    {
                //        if (List_E3DObject[i].AveragePosition.Y > 106)
                //        {
                //            center = List_E3DObject[i].AveragePosition;
                //        }
                //    }

                //}

                //ESphericalCropper eSphericalCropper = new ESphericalCropper(ref center, 7);

                //EPointCloud CropPointCloud = new EPointCloud();
                //eSphericalCropper.Crop(referencePointCloud_, CropPointCloud, true);

                //CropPointCloud.SavePCD($"{fileName}.pcd");

                //E3DPoint top = List_E3DObject[0].LocalTopPosition;
                //E3DPoint average = List_E3DObject[0].AveragePosition;


                //E3DPoint point = new E3DPoint(0, 0, 50);
                //int u = new int();
                //int v = new int();
                //EDepth16 averagevalue = new EDepth16();
                //EDepth16 topvalue = new EDepth16();

                //var checkaverage = EZMap16_.GetPixelPositionFromWorldPosition(average, ref u, ref v, ref averagevalue);
                //var checktop = EZMap16_.GetPixelPositionFromWorldPosition(top, ref u, ref v, ref topvalue);







                //var Run = objRegion.Runs;
                //List<List<int>> List_ERun = new List<List<int>>();
                //for (int i = 0; i < Run.Length; i++)
                //{
                //    List_ERun.Add(new List<int> { Run[i].OrgX, Run[i].Length, Run[i].Y });
                //}

                //ExportToCSV(List_ERun, "newlist.csv");
                //--------------------------------------------------------------------------------------------------------
                //先移除現有的object再註冊新的
                sourceViewer_3D.RemoveCurrent3DObjects();
                sourceViewer_3D.Register3DObjects(extractor_.Objects);

                // Dispose
                extractor_.LengthRange.Dispose();
                extractor_.WidthRange.Dispose();
                extractor_.LocalHeightRange.Dispose();
                extractor_.ReferenceHeightRange.Dispose();
                extractor_.OrientationRange.Dispose();
                extractor_.ReferenceTiltRange.Dispose();
                extractor_.LocalTiltRange.Dispose();
                extractor_.AspectRatioRange.Dispose();
                extractor_.AreaRange.Dispose();
                extractor_.VolumeRange.Dispose();
                
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static void ExportToCSV(List<List<int>> data, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (List<int> row in data)
                {
                    // 將每個整數轉換為字串並用逗號分隔
                    string csvLine = string.Join(",", row);
                    sw.WriteLine(csvLine);
                }
            }

            Console.WriteLine("CSV 匯出成功！");
        }


        private void Setup3DObjectView()
        {
            try
            {
                sourceViewer_3D.SetFocus();
                // set the drawing style for the different object types
                ERenderStyle style = new ERenderStyle();


                //3D

                style.hasLine = true;
                style.hasFill = true;

                style.lineRGB = new EC24A(255, 255, 0);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.BoundingBox);

                style.fillRGB = new EC24A(50, 50, 255, 128);
                style.lineRGB = new EC24A(255, 255, 0);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.BasePlane);

                style.lineRGB = new EC24A(255, 255, 255);
                style.fillRGB = new EC24A(255, 255, 255, 200);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.Plane);

                style.pointRGB = new EC24A(0, 0, 255);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.AveragePosition);

                style.pointRGB = new EC24A(255, 0, 0);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.ReferenceTopPosition);

                style.pointRGB = new EC24A(0, 255, 0);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.LocalTopPosition);

                style.lineRGB = new EC24A(200, 200, 200);
                style.fillRGB = new EC24A(50, 255, 128, 100);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.Sphere);

                //2D
                style.fillRGB = new EC24A(255, 255, 0, 0);
                sourceViewer_3D.SetFeatureStyleForAll3DObjects(style, E3DObjectFeature.ERegion);

                UpdateViewer();
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateViewer()
        {
            if (checkBoxBB.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.BoundingBox);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.BoundingBox);

            if (checkBoxOP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.Plane);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.Plane);

            if (checkBoxAP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.AveragePosition);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.AveragePosition);

            if (checkBox_LTP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.ERectangleRegion);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.ERectangleRegion);

            if (checkBox_RTP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.ReferenceTopPosition);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.ReferenceTopPosition);

            if (checkBox_LTP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.LocalTopPosition);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.LocalTopPosition);

            if (checkBox_Sphere.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.Sphere);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.Sphere);

            if (checkBoxBP.Checked)
                sourceViewer_3D.ShowFeatureForAll3DObjects(E3DObjectFeature.BasePlane);
            else
                sourceViewer_3D.HideFeatureForAll3DObjects(E3DObjectFeature.BasePlane);


            sourceViewer_3D.EnableEDLShading = checkBox_EDL.Checked;


            Invalidate();

        }




        private void Objectclear()
        {
           // sourceViewer_3D.ClearRenderSource();
            sourceViewer_3D.RemoveCurrent3DObjects();
        }

        /// <summary>
        /// 讀取圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objectclear();
            // Show open file dialog.
            referencePointCloud_ = new EPointCloud();
            openFileDialog.Filter = "Image Files (*.tif;*.jpg;*.bmp;*.png)|*.tif;*.jpg;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                // No image selected, exit
                return;
            }
            ZmapGenerator.ResolutionForm resolutionForm = new ZmapGenerator.ResolutionForm();
            if (resolutionForm.ShowDialog() == DialogResult.Cancel)
            {
                // No resolution set, exit
                return;
            }
            // get the selected path
            string strtemp = openFileDialog.FileName;

            image_ = new EImageBW8();
            try
            {
                EZMap8 zmap8 = new EZMap8();
                zmap8.LoadImage(strtemp);

                zmap8.SetResolution(resolutionForm.rx, resolutionForm.ry, resolutionForm.rz);

                if (generatedZMap_ != null)
                {
                    generatedZMap_.Dispose();
                    generatedZMap_ = null;
                }
                generatedZMap_ = zmap8;
                image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                using (EImageBW8 tmp = ((EZMap8)generatedZMap_).AsEImage())
                    EasyImage.Copy(tmp, image_);

                //EZMap16 zmap16 = new EZMap16();
                //zmap16.LoadImage(strtemp);

                //if (generatedZMap_ != null)
                //{
                //    generatedZMap_.Dispose();
                //    generatedZMap_ = null;
                //}
                //generatedZMap_ = zmap16;
                //image_.SetSize(generatedZMap_.Width, generatedZMap_.Height);
                //using (EImageBW16 tmp16  = new EImageBW16(generatedZMap_.AsEImage())) {
                //    EasyImage.Copy(tmp16, image_);
                //}

            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                InitRegions();

                GeneratePointCloud();

                SuggestObjectValue();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Refresh();
        }
        /// <summary>
        /// Zmap轉換3D物件 EZMapToPointCloudConverter
        /// </summary>
        private void GeneratePointCloud()
        {
            EZMapToPointCloudConverter converter = new EZMapToPointCloudConverter();
            try
            {
                converter.Convert(generatedZMap_, referencePointCloud_, true);

                // pass the pointcloud to the 3DViewer
                if (sourceViewer_3D != null)
                {
                    sourceViewer_3D.RemoveCurrent3DObjects();

                    if (referencePointCloud_.NumPoints > 0)
                    {
                        sourceViewer_3D.ConfigureRenderSource(referencePointCloud_);
                        sourceViewer_3D.GenerateColors(EColorRampMode.HueFromZ);
                    }
                }

                referencePointCloud_.Dispose();
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 滑鼠縮放事件
        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!isMouseOverPanel)
            {
                return; // 鼠標不在 Panel 控制項範圍內，不縮放圖片
            }
            if(image_ == null)
            {
                return;
            }
            if (image_.IsVoid)// If image is empty, exit
            {
                return;
            }
            // 使用滑鼠滾輪來進行縮放
            float scaleFactor = 1.5f; // 縮放因子，你可以調整這個值來控制縮放速度

            if (e.Delta > 0)
            {
                // 向前滾動，放大圖片
                scale *= scaleFactor;
            }
            else
            {
                // 向後滾動，縮小圖片
                scale /= scaleFactor;
            }

            // 限制縮放範圍，避免過小或過大
            scale = Math.Max(scale, 0.1f); // 最小縮放比例為 0.1
            scale = Math.Min(scale, 10.0f); // 最大縮放比例為 10

            // 重新繪製控制項
            this.Invalidate();
            Refresh();


        }
        /// <summary>
        /// 鼠標進入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverPanel = true;
        }
        /// <summary>
        /// 鼠標離開事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverPanel = false;
        }
        #endregion

        #region 自動參數
        /// <summary>
        /// 自動預設參數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SuggestValue_Click(object sender, EventArgs e)
        {
            SuggestObjectValue();
        }
        /// <summary>
        /// f取得自動預設參數
        /// </summary>
        private void SuggestObjectValue()
        {   
            if (generatedZMap_ == null)
            {
                return;
            }
            try
            {
                extractor_ = new E3DObjectExtractor();
                E3DPoint resolution = generatedZMap_.GetResolution();

                int zmap_size = Math.Max(generatedZMap_.Width, generatedZMap_.Height);

                // object length/width
                float minLW = (float)Math.Floor(2.0 + 0.001 * zmap_size) * Math.Min(resolution.X, resolution.Y);
                float maxLW = 0.25f * zmap_size * Math.Max(resolution.X, resolution.Y);

                maxLW = Math.Max(minLW, maxLW);


                // object height
                float minHeight = 4.0f * resolution.Z;
                float maxHeight = 256.0f * resolution.Z;
                if (generatedZMap_.Type == EImageType.Depth16)
                    maxHeight = 65536.0f * resolution.Z;

                maxHeight = Math.Max(minHeight, maxHeight);

                // object area
                float minArea = minLW * minLW;
                float maxArea = maxLW * maxLW;
                extractor_.AreaRange = new EFloatRange(minArea, maxArea);
                extractor_.LengthRange.Dispose();
                extractor_.WidthRange.Dispose();
                extractor_.LocalHeightRange.Dispose();
                extractor_.ReferenceHeightRange.Dispose();
                extractor_.OrientationRange.Dispose();
                extractor_.ReferenceTiltRange.Dispose();
                extractor_.LocalTiltRange.Dispose();
                extractor_.AspectRatioRange.Dispose();
                extractor_.AreaRange.Dispose();
                extractor_.VolumeRange.Dispose();
                // object volume
                float minVolume = minArea * minHeight;
                float maxVolume = maxArea * maxHeight;
                extractor_.ContourReinforce = true;

                //txt_Length_from.Text = Math.Round(minLW, 3).ToString();
                //txt_Length_to.Text = Math.Round(maxLW, 3).ToString();

                //txt_Width_from.Text = Math.Round(minLW, 3).ToString();
                //txt_Width_to.Text = Math.Round(maxLW, 3).ToString();

                //txt_Local_height_from.Text = Math.Round(minHeight, 3).ToString();
                //txt_Local_height_to.Text = Math.Round(maxHeight, 3).ToString();

                //txt_Refrence_height_from.Text = Math.Round(minHeight, 3).ToString();
                //txt_Refrence_height_to.Text = Math.Round(maxHeight, 3).ToString();

                txt_Length_from.Text = 4.ToString();
                txt_Length_to.Text = 40.ToString();

                txt_Width_from.Text = 4.ToString();
                txt_Width_to.Text = 40.ToString();

                txt_Local_height_from.Text = 4.ToString();
                txt_Local_height_to.Text = 40.ToString();

                txt_Refrence_height_from.Text = 4.ToString();
                txt_Refrence_height_to.Text = 40.ToString();

                txt_Orientation_from.Text = "-90";
                txt_Orientation_to.Text = "90";

                txt_Loacl_tilt_from.Text = "0";
                txt_Loacl_tilt_to.Text = "90";

                txt_Refrence_tilt_from.Text = "0";
                txt_Refrence_tilt_to.Text = "90";

                txt_Aspect_ratio_from.Text = "0.8";
                txt_Aspect_to.Text = "1";

                txt_Area_from.Text = Math.Round(minArea, 3).ToString();
                txt_Area_to.Text = Math.Round(maxArea, 3).ToString();

                txt_Volume_from.Text = Math.Round(minVolume, 3).ToString();
                txt_Volume_to.Text = Math.Round(maxVolume, 3).ToString();
            }
            catch (EException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if((int)e.KeyChar == 45 | (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }
        /// <summary>
        /// 建立ListView屬性
        /// </summary>
        private void InitListView()
        {
            ObjlistView.View = View.Details;
            ObjlistView.MultiSelect = false;
            ObjlistView.FullRowSelect = true;
            ObjlistView.Scrollable = true;
            ColumnHeader header = new ColumnHeader();

            if (List_E3DObject.Count < 0)
            {
                return;
            }
            ObjlistView.Items.Clear();
            String[] ListItems = new string[17];


            for (int i = 0; i < List_E3DObject.Count; i++)
            {
                ListItems[0] = i.ToString();
                ListItems[1] = List_E3DObject[i].Length.ToString("0.###");
                ListItems[2] = List_E3DObject[i].Width.ToString("0.###");
                ListItems[3] = List_E3DObject[i].LocalHeight.ToString("0.###");
                ListItems[4] = List_E3DObject[i].ReferenceHeight.ToString("0.###");
                ListItems[5] = List_E3DObject[i].Orientation.ToString("0.###");
                ListItems[6] = List_E3DObject[i].LocalTilt.ToString("0.###");
                ListItems[7] = List_E3DObject[i].ReferenceTilt.ToString("0.###");
                ListItems[8] = List_E3DObject[i].AspectRatio.ToString("0.###");
                ListItems[9] = List_E3DObject[i].Area.ToString("0.###");
                ListItems[10] = List_E3DObject[i].Volume.ToString("0.###");
                ListItems[11] = List_E3DObject[i].ReferenceTopPosition.X.ToString("0.###");
                ListItems[12] = List_E3DObject[i].ReferenceTopPosition.Y.ToString("0.###");
                ListItems[13] = List_E3DObject[i].ReferenceTopPosition.Z.ToString("0.###");
                ListItems[14] = List_E3DObject[i].AveragePosition.X.ToString("0.###");
                ListItems[15] = List_E3DObject[i].AveragePosition.Y.ToString("0.###");
                ListItems[16] = List_E3DObject[i].AveragePosition.Z.ToString("0.###");

                ListViewItem listViewItem = new ListViewItem(ListItems);


                ObjlistView.Items.Add(listViewItem);
            }
        }
        private void SetViewToObject(int index)
        {   
            if(List_E3DObject.Count <= 0)
            {
                return;
            }
            Setup3DObjectView();

            var center = List_E3DObject[index].AveragePosition;
            var top = List_E3DObject[index].LocalTopPosition;
            sourceViewer_3D.SetFocus();
            sourceViewer_3D.SetViewTarget(center.X, center.Y, top.Z);

            float distance = Math.Max(m_minDistanceToObjects, 2 * List_E3DObject[index].BoundingBox.XSize);
            //sourceViewer_3D.SetViewDistance(distance);

            // set the viewing y-angle to 30 degrees (the angle unit was set to degrees in the 3DObjectExtraction)
            sourceViewer_3D.SetViewAngle(0, 0);
            sourceViewer_3D.ViewDistance = distance;
            
            Invalidate();
        }



        public static void ListViewToCSV(System.Windows.Forms.ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }
        private void ReloadListView()
        {

        }
        private void ObjlistView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == listViewItemComparer.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (listViewItemComparer.Order == SortOrder.Ascending)
                {
                    listViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    listViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                listViewItemComparer.SortColumn = e.Column;
                listViewItemComparer.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.ObjlistView.Sort();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ListViewToCSV(ObjlistView, $"{fileName}.csv", true);
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (generatedZMap_ != null)
            {
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "Open eVision|*.*|PNG (*.png)|*.png";

                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    // Extract the path string
                //    string path = saveFileDialog1.FileName;
                //    try
                //    {
                //        if (path.EndsWith(".png"))
                //        {
                //            if (generatedZMap_.Type == EImageType.Depth32f)
                //                MessageBox.Show("EZMap32f cannot be saved as Image", "Save ZMap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            else
                //                generatedZMap_.SaveImage(path);
                //        }
                //        else
                //            generatedZMap_.Save(path);
                //    }
                //    catch (EException exc)
                //    {
                //        MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                Bitmap drawbitmap = DrawToBmp(image_);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "bmp";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 保存 Bitmap 到所选文件
                    string filePath = saveFileDialog.FileName;
                    drawbitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
                    Console.WriteLine("Bitmap saved to: " + filePath);
                }
            }
            else
            {
                MessageBox.Show("Please load data and generate a zmap before saving it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObjlistView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem clickedItem = ObjlistView.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    int selectedItem = int.Parse(clickedItem.Text);
                }


                if (List_E3DObject.Count > 0)
                {
                    Set3DView(selectedItem);
                }


            }
        }

        private void Set3DView(int index)
        {
            //sourceViewer_3D.SetFocus();
            //E3DPoint center = List_E3DObject[selectedItem].AveragePosition;
            //E3DPoint top = List_E3DObject[selectedItem].ReferenceTopPosition;

            //sourceViewer_3D.SetViewTarget(center.X, center.Y, top.Z);
            //////float distance = Math.Max(m_minDistanceToObjects, 2 * List_E3DObject[selectedItem].BoundingBox.XSize);
            //Refresh();
        }

        private void CheckBox_CheckedChange(object sender, EventArgs e)
        {
            UpdateViewer();

            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(image_ == null)
            {
                return;
            }
            if (image_.IsVoid)
            {
                return;
            }
            Bitmap drawbitmap = DrawToBmp(image_);
            //Graphics graphics = Graphics.FromImage(drawbitmap);
            Graphics graphics = e.Graphics;

            int scaledWidth = (int)(drawbitmap.Width * scale);
            int scaledHeight = (int)(drawbitmap.Height * scale);

            graphics.DrawImage(drawbitmap, new Rectangle(0, 0, scaledWidth, scaledHeight));

            Pen p = new Pen(Color.Yellow);

            //if (CB_ROI.Checked)
            //{
            //    ERGBColor color = new ERGBColor(0, 0, 255);

            //    m_RectRegion.Draw(graphics, color, 0.2f, scale, scale);
            //    m_RectRegion.DrawContour(graphics, color, scale, scale);
            //    m_RectRegion.DrawHandles(graphics, color, scale, scale);
            //}

            if (List_E3DObject.Count > 0)
            {
                if (checkBoxEROI.Checked)
                {   
                    for(int i =0;i<List_E3DObject.Count;i++)
                    {
                        ERegion eRegion = List_E3DObject[i].Region;

                        //List_E3DObject[i].Region.Draw(graphics, 128, scale, scale);

                        //int eroiX = (int)(List_E3DObject[i].Region.BoundingBoxOrgX * scale);
                        //int eroiY = (int)(List_E3DObject[i].Region.BoundingBoxOrgY * scale);
                        //int eroiWidth = (int)(List_E3DObject[i].Region.BoundingBoxWidth * scale);
                        //int eroiHeight = (int)(List_E3DObject[i].Region.BoundingBoxHeight * scale);
                        //graphics.DrawRectangle(p, new Rectangle(eroiX, eroiY, eroiWidth, eroiHeight));
                        //List_E3DObject[i].Region.Draw(graphics, scale, scale);
                        List_E3DObject[i].Region.DrawContour(graphics, scale, scale);


                        var perimeter = List_E3DObject[i].RectangleRegion;
                    }
                }
            }
        }

        public Bitmap DrawToBmp<T>(T bw8OrC24, PixelFormat pixelFormat = PixelFormat.Format24bppRgb) where T : EBaseROI
        {
            Bitmap bmp = new Bitmap(bw8OrC24.Width, bw8OrC24.Height, pixelFormat);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                bw8OrC24.Draw(g);
            }

            return bmp;
        }

        public  Bitmap ToBitmap(EImageC24 _this)
        {
            Bitmap bitmap = new Bitmap(_this.Width, _this.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                _this.Draw(g);
                g.Dispose();
            }
            return bitmap;
        }

        private void btn_Generator_Click(object sender, EventArgs e)
        {
            //Objectclear();
            //EPointCloud pointCloud_ = EPointCloudFactory.CreateSphericPointCloud(new E3DPoint(0, 0, 0), 5.0f, 50, 50);
            //sourceViewer_3D.AddRenderSource("Default", pointCloud_);
            //EColorRampMode colorRampMode_ = EColorRampMode.HueFromZ;
            //sourceViewer_3D.ColorRampMode = colorRampMode_;

            //sourceViewer_3D.Show();
            //sourceViewer_3D.SetFocus();


            //EZMap16 eZMap16 = new EZMap16();
            //EPointCloudToZMapConverter pctozmap = new EPointCloudToZMapConverter();

            //pctozmap.SetFillMode(EFillUndefinedPixelsDirection.Vertical, EFillUndefinedPixelsMethod.KeepMinimum);
            //pctozmap.Convert(pointCloud_, eZMap16);
            //EZMapToPointCloudConverter zmaptopc = new EZMapToPointCloudConverter();
            //zmaptopc.Convert(eZMap16, pointCloud_, true);  //建立出的Zmap空間的PointCloud

            //if (generatedZMap_ != null)
            //{
            //    generatedZMap_.Dispose();
            //    generatedZMap_ = null;
            //}

            //generatedZMap_ = new EZMap16();

            //EImageBW16 image16_ = new EImageBW16();
            //generatedZMap_ = eZMap16;
            //image16_.SetSize(generatedZMap_.Width, generatedZMap_.Height);

            
            //try
            //{
            //    //3DViewer根據剛剛從Zmap建立的PD空間(referencePointCloud_)當作參照
            //    sourceViewer_3D.RemoveAllRenderSources();
            //    sourceViewer_3D.AddRenderSource("Reference", pointCloud_);
               

            //    sourceViewer_3D.SetRenderSourceColorMode("Reference", ESourceColorMode.Ramp);
            //    sourceViewer_3D.ResetView();
            //    sourceViewer_3D.SetFocus();
            //}
            //catch (EException exc)
            //{
            //    MessageBox.Show(exc.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            Refresh();



        }
        /// <summary>
        /// 透過ERegion切割，所以是用圖片(zmap)切割後再轉PCD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_view_Click(object sender, EventArgs e)
        {   

            if (List_E3DObject.Count <= 0)
            {
                return;
            }
            ERegion eRegion = List_E3DObject[1].Region;
            //EPolygonRegion region = new EPolygonRegion(points);  // could be any type of ERegion
            EZMap16 zmapCropped = new EZMap16(generatedZMap_.Width, generatedZMap_.Height);
            //EZMap16 zmapCropped = new EZMap16(eRegion.BoundingBoxWidth, eRegion.BoundingBoxHeight);
            
            EZMap16 tmpzmap = (EZMap16)generatedZMap_;
            try
            {
                EUtils.Copy(tmpzmap.UndefinedValue, zmapCropped);
                EUtils.Copy(tmpzmap, eRegion, zmapCropped);
            }
            catch (EException ex) {
                MessageBox.Show(ex.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //image_.SetSize(zmapCropped.Width, zmapCropped.Height);
            //using (EImageBW16 tmp = ((EZMap16)zmapCropped).AsEImage())
            //{
            //    EasyImage.Convert(tmp, image_);
            //    //EasyImage.Convert(image_, image_C24);
            //}
            //Bitmap drawbitmap = DrawToBmp(image_);
            //drawbitmap.Save("savecropped.png");

            EPointCloud SaveePointCloud = new EPointCloud();
            EZMapToPointCloudConverter zmaptopc = new EZMapToPointCloudConverter();
            zmaptopc.Convert(zmapCropped, SaveePointCloud, true);  //建立出的Zmap空間的PointCloud
            SaveePointCloud.SavePCD("savecropped.pcd");



            //int ItemsizeInBytes = 4;  // an EC24A is 4 bytes 
            //Byte[] data = new Byte[SaveePointCloud.NumPoints * ItemsizeInBytes];

            //// case 1: data is Color, Normal, Intensity, Texture, Index, Confidence or Distance 
            //try
            //{
            //    Marshal.Copy(SaveePointCloud.GetAttributeBuffer((int)E3DAttribute.Color), data, 0, SaveePointCloud.NumPoints * ItemsizeInBytes);

            //}
            //catch (EException ex)
            //{
            //    MessageBox.Show(ex.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //// case 2: data is something else 
            //int attributeOffset = 17;  // value retrieved when we initialized the attribute 
            //try
            //{
            //    Marshal.Copy(SaveePointCloud.GetAttributeBuffer(attributeOffset), data, 0, SaveePointCloud.NumPoints * ItemsizeInBytes);

            //}
            //catch (EException ex)
            //{
            //    MessageBox.Show(ex.What(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void ObjlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ObjlistView.SelectedItems)
            {
                int index = item.Index;
                SetViewToObject(index);
            }
        }

        private void pictureBox_3D_Paint(object sender, PaintEventArgs e)
        {
            Refresh();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m_Dragging = 1;
            EEditionMode regionHitMode = EEditionMode.None;

            if (CB_ROI.Checked)
            {
                regionHitMode = m_RectRegion.HitTest(e.X, e.Y, scale, scale);
            }
            if (regionHitMode != EEditionMode.None)
            {
                m_Dragging = 2;
            }
                
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {   
            
            if (CB_ROI.Checked)
            {   
                if(m_Dragging == 2)
                {
                    m_RectRegion.Drag(e.X, e.Y, scale, scale);
                }
            }
            Invalidate();
        }

        private void savePointCloudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("●");

            var num = generatedZMap_.Width;
            //EImageBW16 eImageBW16 =  new EImageBW16(generatedZMap_.AsEImage());
            //Bitmap drawbitmap = DrawToBmp(eImageBW16);
            //drawbitmap.Save("bpm.png");


            //List<E3DPoint> e3DPoints = new List<E3DPoint>();    
            //for (uint i = 0; i < referencePointCloud_.NumPoints; i++) {
            //    e3DPoints.Add(referencePointCloud_.GetPoint(i));
            //}
            //E3DPoint e3DPoint2 = new E3DPoint();
            //int outindex = 0;
            ////referencePointCloud_.DistanceToLine(e3DPoints[0], e3DPoints[referencePointCloud_.NumPoints - 1], out e3DPoint2, out outindex);
            ////EPointCloudStatistics ePointCloudStatistics_ = new EPointCloudStatistics();
            //e3DPoint2 = EPointCloudStatistics.GetPointCloudCentroid(referencePointCloud_);

            //EFloatRange eFloatRange = new EFloatRange();
            //eFloatRange.SetBounds(0, 5);
            //EPointCloudStatistics.GetPointCloudBounds(referencePointCloud_, eFloatRange, eFloatRange, eFloatRange);
        }
    }
}
