namespace ZmapGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sourceViewerWindow = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_3D = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_objextract = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_ROI = new System.Windows.Forms.CheckBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_Generator = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.cbContourReinforce = new System.Windows.Forms.CheckBox();
            this.btn_SuggestValue = new System.Windows.Forms.Button();
            this.txt_Volume_to = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_Volume_from = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_Aspect_to = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_Aspect_ratio_from = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_Refrence_tilt_to = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Refrence_tilt_from = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_Loacl_tilt_to = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Loacl_tilt_from = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Length_to = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Length_from = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Width_to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Width_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_Orientation_to = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Orientation_from = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Refrence_height_to = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Refrence_height_from = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_Local_height_to = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Local_height_from = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Area_to = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Area_from = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ObjlistView = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local_Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ref_Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orientation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local_Tilt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ref_Tilt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aspect_Ratio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Top_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Top_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Top_Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avg_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avg_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avg_Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxOP = new System.Windows.Forms.CheckBox();
            this.checkBoxBB = new System.Windows.Forms.CheckBox();
            this.checkBoxEROI = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_LTP = new System.Windows.Forms.CheckBox();
            this.checkBoxBP = new System.Windows.Forms.CheckBox();
            this.checkBoxAP = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_RTP = new System.Windows.Forms.CheckBox();
            this.checkBox_Sphere = new System.Windows.Forms.CheckBox();
            this.checkBox_EDL = new System.Windows.Forms.CheckBox();
            this.checkBox_Spherefitting = new System.Windows.Forms.CheckBox();
            this.savePointCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3D)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.LoadImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.savePointCloudToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadToolStripMenuItem.Text = "Load PointCloud";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // LoadImageToolStripMenuItem
            // 
            this.LoadImageToolStripMenuItem.Name = "LoadImageToolStripMenuItem";
            this.LoadImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.LoadImageToolStripMenuItem.Text = "Load Image";
            this.LoadImageToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // sourceViewerWindow
            // 
            this.sourceViewerWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sourceViewerWindow.AutoScroll = true;
            this.sourceViewerWindow.BackColor = System.Drawing.SystemColors.Control;
            this.sourceViewerWindow.Location = new System.Drawing.Point(178, 219);
            this.sourceViewerWindow.Name = "sourceViewerWindow";
            this.sourceViewerWindow.Size = new System.Drawing.Size(347, 291);
            this.sourceViewerWindow.TabIndex = 1;
            this.sourceViewerWindow.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox_3D);
            this.groupBox1.Controls.Add(this.sourceViewerWindow);
            this.groupBox1.Location = new System.Drawing.Point(380, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 520);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3D Viewer";
            // 
            // pictureBox_3D
            // 
            this.pictureBox_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_3D.Location = new System.Drawing.Point(3, 18);
            this.pictureBox_3D.Name = "pictureBox_3D";
            this.pictureBox_3D.Size = new System.Drawing.Size(554, 499);
            this.pictureBox_3D.TabIndex = 2;
            this.pictureBox_3D.TabStop = false;
            this.pictureBox_3D.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_3D_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 520);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2D Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 499);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_objextract
            // 
            this.btn_objextract.AllowDrop = true;
            this.btn_objextract.Location = new System.Drawing.Point(139, 359);
            this.btn_objextract.Name = "btn_objextract";
            this.btn_objextract.Size = new System.Drawing.Size(140, 29);
            this.btn_objextract.TabIndex = 4;
            this.btn_objextract.Text = "Extract";
            this.btn_objextract.UseVisualStyleBackColor = true;
            this.btn_objextract.Click += new System.EventHandler(this.btn_objextract_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Spherefitting);
            this.groupBox3.Controls.Add(this.CB_ROI);
            this.groupBox3.Controls.Add(this.btn_view);
            this.groupBox3.Controls.Add(this.btn_Generator);
            this.groupBox3.Controls.Add(this.btn_export);
            this.groupBox3.Controls.Add(this.cbContourReinforce);
            this.groupBox3.Controls.Add(this.btn_SuggestValue);
            this.groupBox3.Controls.Add(this.txt_Volume_to);
            this.groupBox3.Controls.Add(this.btn_objextract);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.txt_Volume_from);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txt_Aspect_to);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txt_Aspect_ratio_from);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txt_Refrence_tilt_to);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txt_Refrence_tilt_from);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txt_Loacl_tilt_to);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_Loacl_tilt_from);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_Length_to);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_Length_from);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_Width_to);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_Width_from);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txt_Orientation_to);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_Orientation_from);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txt_Refrence_height_to);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_Refrence_height_from);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_Local_height_to);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_Local_height_from);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_Area_to);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_Area_from);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 463);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3D extraction parameters";
            // 
            // CB_ROI
            // 
            this.CB_ROI.AutoSize = true;
            this.CB_ROI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_ROI.Enabled = false;
            this.CB_ROI.Location = new System.Drawing.Point(8, 331);
            this.CB_ROI.Name = "CB_ROI";
            this.CB_ROI.Size = new System.Drawing.Size(47, 16);
            this.CB_ROI.TabIndex = 65;
            this.CB_ROI.Text = "ROI:";
            this.CB_ROI.UseVisualStyleBackColor = true;
            // 
            // btn_view
            // 
            this.btn_view.AllowDrop = true;
            this.btn_view.Location = new System.Drawing.Point(171, 328);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(42, 21);
            this.btn_view.TabIndex = 64;
            this.btn_view.Text = "view";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_Generator
            // 
            this.btn_Generator.AllowDrop = true;
            this.btn_Generator.Location = new System.Drawing.Point(224, 304);
            this.btn_Generator.Name = "btn_Generator";
            this.btn_Generator.Size = new System.Drawing.Size(50, 21);
            this.btn_Generator.TabIndex = 63;
            this.btn_Generator.Text = "Gen";
            this.btn_Generator.UseVisualStyleBackColor = true;
            this.btn_Generator.Click += new System.EventHandler(this.btn_Generator_Click);
            // 
            // btn_export
            // 
            this.btn_export.AllowDrop = true;
            this.btn_export.Location = new System.Drawing.Point(171, 304);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(50, 21);
            this.btn_export.TabIndex = 62;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // cbContourReinforce
            // 
            this.cbContourReinforce.AutoSize = true;
            this.cbContourReinforce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbContourReinforce.Checked = true;
            this.cbContourReinforce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContourReinforce.Location = new System.Drawing.Point(6, 309);
            this.cbContourReinforce.Name = "cbContourReinforce";
            this.cbContourReinforce.Size = new System.Drawing.Size(141, 16);
            this.cbContourReinforce.TabIndex = 61;
            this.cbContourReinforce.Text = "Contour Reinforcement: ";
            this.cbContourReinforce.UseVisualStyleBackColor = true;
            // 
            // btn_SuggestValue
            // 
            this.btn_SuggestValue.AllowDrop = true;
            this.btn_SuggestValue.Location = new System.Drawing.Point(5, 359);
            this.btn_SuggestValue.Name = "btn_SuggestValue";
            this.btn_SuggestValue.Size = new System.Drawing.Size(88, 29);
            this.btn_SuggestValue.TabIndex = 60;
            this.btn_SuggestValue.Text = "Suggest Value";
            this.btn_SuggestValue.UseVisualStyleBackColor = true;
            this.btn_SuggestValue.Click += new System.EventHandler(this.btn_SuggestValue_Click);
            // 
            // txt_Volume_to
            // 
            this.txt_Volume_to.Location = new System.Drawing.Point(224, 276);
            this.txt_Volume_to.Name = "txt_Volume_to";
            this.txt_Volume_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Volume_to.TabIndex = 59;
            this.txt_Volume_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(197, 282);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 12);
            this.label29.TabIndex = 58;
            this.label29.Text = "To: ";
            // 
            // txt_Volume_from
            // 
            this.txt_Volume_from.Location = new System.Drawing.Point(136, 276);
            this.txt_Volume_from.Name = "txt_Volume_from";
            this.txt_Volume_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Volume_from.TabIndex = 57;
            this.txt_Volume_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(101, 282);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 12);
            this.label30.TabIndex = 56;
            this.label30.Text = "From:";
            // 
            // txt_Aspect_to
            // 
            this.txt_Aspect_to.Location = new System.Drawing.Point(224, 218);
            this.txt_Aspect_to.Name = "txt_Aspect_to";
            this.txt_Aspect_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Aspect_to.TabIndex = 55;
            this.txt_Aspect_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(197, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 12);
            this.label27.TabIndex = 54;
            this.label27.Text = "To: ";
            // 
            // txt_Aspect_ratio_from
            // 
            this.txt_Aspect_ratio_from.Location = new System.Drawing.Point(136, 218);
            this.txt_Aspect_ratio_from.Name = "txt_Aspect_ratio_from";
            this.txt_Aspect_ratio_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Aspect_ratio_from.TabIndex = 53;
            this.txt_Aspect_ratio_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(101, 224);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 12);
            this.label28.TabIndex = 52;
            this.label28.Text = "From:";
            // 
            // txt_Refrence_tilt_to
            // 
            this.txt_Refrence_tilt_to.Location = new System.Drawing.Point(224, 189);
            this.txt_Refrence_tilt_to.Name = "txt_Refrence_tilt_to";
            this.txt_Refrence_tilt_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Refrence_tilt_to.TabIndex = 51;
            this.txt_Refrence_tilt_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(197, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 12);
            this.label23.TabIndex = 50;
            this.label23.Text = "To: ";
            // 
            // txt_Refrence_tilt_from
            // 
            this.txt_Refrence_tilt_from.Location = new System.Drawing.Point(136, 189);
            this.txt_Refrence_tilt_from.Name = "txt_Refrence_tilt_from";
            this.txt_Refrence_tilt_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Refrence_tilt_from.TabIndex = 49;
            this.txt_Refrence_tilt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(101, 195);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 12);
            this.label26.TabIndex = 48;
            this.label26.Text = "From:";
            // 
            // txt_Loacl_tilt_to
            // 
            this.txt_Loacl_tilt_to.Location = new System.Drawing.Point(224, 160);
            this.txt_Loacl_tilt_to.Name = "txt_Loacl_tilt_to";
            this.txt_Loacl_tilt_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Loacl_tilt_to.TabIndex = 47;
            this.txt_Loacl_tilt_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 12);
            this.label14.TabIndex = 46;
            this.label14.Text = "To: ";
            // 
            // txt_Loacl_tilt_from
            // 
            this.txt_Loacl_tilt_from.Location = new System.Drawing.Point(136, 160);
            this.txt_Loacl_tilt_from.Name = "txt_Loacl_tilt_from";
            this.txt_Loacl_tilt_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Loacl_tilt_from.TabIndex = 45;
            this.txt_Loacl_tilt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 12);
            this.label18.TabIndex = 44;
            this.label18.Text = "From:";
            // 
            // txt_Length_to
            // 
            this.txt_Length_to.Location = new System.Drawing.Point(224, 15);
            this.txt_Length_to.Name = "txt_Length_to";
            this.txt_Length_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Length_to.TabIndex = 43;
            this.txt_Length_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "To: ";
            // 
            // txt_Length_from
            // 
            this.txt_Length_from.Location = new System.Drawing.Point(136, 15);
            this.txt_Length_from.Name = "txt_Length_from";
            this.txt_Length_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Length_from.TabIndex = 41;
            this.txt_Length_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 12);
            this.label17.TabIndex = 40;
            this.label17.Text = "From:";
            // 
            // txt_Width_to
            // 
            this.txt_Width_to.Location = new System.Drawing.Point(224, 44);
            this.txt_Width_to.Name = "txt_Width_to";
            this.txt_Width_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Width_to.TabIndex = 39;
            this.txt_Width_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "To: ";
            // 
            // txt_Width_from
            // 
            this.txt_Width_from.Location = new System.Drawing.Point(136, 44);
            this.txt_Width_from.Name = "txt_Width_from";
            this.txt_Width_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Width_from.TabIndex = 37;
            this.txt_Width_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "From:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 12);
            this.label25.TabIndex = 26;
            this.label25.Text = "Width";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 12);
            this.label24.TabIndex = 35;
            this.label24.Text = "Length";
            // 
            // txt_Orientation_to
            // 
            this.txt_Orientation_to.Location = new System.Drawing.Point(224, 131);
            this.txt_Orientation_to.Name = "txt_Orientation_to";
            this.txt_Orientation_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Orientation_to.TabIndex = 33;
            this.txt_Orientation_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(197, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 12);
            this.label21.TabIndex = 32;
            this.label21.Text = "To: ";
            // 
            // txt_Orientation_from
            // 
            this.txt_Orientation_from.Location = new System.Drawing.Point(136, 131);
            this.txt_Orientation_from.Name = "txt_Orientation_from";
            this.txt_Orientation_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Orientation_from.TabIndex = 31;
            this.txt_Orientation_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 12);
            this.label22.TabIndex = 30;
            this.label22.Text = "From:";
            // 
            // txt_Refrence_height_to
            // 
            this.txt_Refrence_height_to.Location = new System.Drawing.Point(224, 102);
            this.txt_Refrence_height_to.Name = "txt_Refrence_height_to";
            this.txt_Refrence_height_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Refrence_height_to.TabIndex = 29;
            this.txt_Refrence_height_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(197, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 12);
            this.label19.TabIndex = 28;
            this.label19.Text = "To: ";
            // 
            // txt_Refrence_height_from
            // 
            this.txt_Refrence_height_from.Location = new System.Drawing.Point(136, 102);
            this.txt_Refrence_height_from.Name = "txt_Refrence_height_from";
            this.txt_Refrence_height_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Refrence_height_from.TabIndex = 27;
            this.txt_Refrence_height_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(101, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 12);
            this.label20.TabIndex = 26;
            this.label20.Text = "From:";
            // 
            // txt_Local_height_to
            // 
            this.txt_Local_height_to.Location = new System.Drawing.Point(224, 73);
            this.txt_Local_height_to.Name = "txt_Local_height_to";
            this.txt_Local_height_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Local_height_to.TabIndex = 21;
            this.txt_Local_height_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(197, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "To: ";
            // 
            // txt_Local_height_from
            // 
            this.txt_Local_height_from.Location = new System.Drawing.Point(136, 73);
            this.txt_Local_height_from.Name = "txt_Local_height_from";
            this.txt_Local_height_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Local_height_from.TabIndex = 19;
            this.txt_Local_height_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "From:";
            // 
            // txt_Area_to
            // 
            this.txt_Area_to.Location = new System.Drawing.Point(224, 247);
            this.txt_Area_to.Name = "txt_Area_to";
            this.txt_Area_to.Size = new System.Drawing.Size(55, 22);
            this.txt_Area_to.TabIndex = 13;
            this.txt_Area_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "To: ";
            // 
            // txt_Area_from
            // 
            this.txt_Area_from.Location = new System.Drawing.Point(136, 247);
            this.txt_Area_from.Name = "txt_Area_from";
            this.txt_Area_from.Size = new System.Drawing.Size(55, 22);
            this.txt_Area_from.TabIndex = 11;
            this.txt_Area_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Volume";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aspect ratio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Refrence tilt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Local tilt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orientation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reference height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local height";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.ObjlistView);
            this.groupBox4.Location = new System.Drawing.Point(12, 496);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 117);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extracted object";
            // 
            // ObjlistView
            // 
            this.ObjlistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Length,
            this.Width,
            this.Local_Height,
            this.Ref_Height,
            this.Orientation,
            this.Local_Tilt,
            this.Ref_Tilt,
            this.Aspect_Ratio,
            this.Area,
            this.Volume,
            this.Top_X,
            this.Top_Y,
            this.Top_Z,
            this.Avg_X,
            this.Avg_Y,
            this.Avg_Z});
            this.ObjlistView.HideSelection = false;
            this.ObjlistView.Location = new System.Drawing.Point(4, 14);
            this.ObjlistView.Name = "ObjlistView";
            this.ObjlistView.Size = new System.Drawing.Size(276, 97);
            this.ObjlistView.TabIndex = 0;
            this.ObjlistView.UseCompatibleStateImageBehavior = false;
            this.ObjlistView.View = System.Windows.Forms.View.Details;
            this.ObjlistView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ObjlistView_ColumnClick);
            this.ObjlistView.SelectedIndexChanged += new System.EventHandler(this.ObjlistView_SelectedIndexChanged);
            this.ObjlistView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjlistView_MouseDown);
            // 
            // Index
            // 
            this.Index.Text = "Index";
            // 
            // Length
            // 
            this.Length.Text = "Length";
            // 
            // Width
            // 
            this.Width.Text = "Width";
            // 
            // Local_Height
            // 
            this.Local_Height.Text = "Local Height";
            // 
            // Ref_Height
            // 
            this.Ref_Height.Text = "Ref. Height";
            // 
            // Orientation
            // 
            this.Orientation.Text = "Orientation";
            // 
            // Local_Tilt
            // 
            this.Local_Tilt.Text = "Local Tilt";
            // 
            // Ref_Tilt
            // 
            this.Ref_Tilt.Text = "Ref. Tilt";
            // 
            // Aspect_Ratio
            // 
            this.Aspect_Ratio.Text = "Aspect Ratio";
            // 
            // Area
            // 
            this.Area.Text = "Area";
            // 
            // Volume
            // 
            this.Volume.Text = "Volume";
            // 
            // Top_X
            // 
            this.Top_X.Text = "Top X";
            // 
            // Top_Y
            // 
            this.Top_Y.Text = "Top Y";
            // 
            // Top_Z
            // 
            this.Top_Z.Text = "Top Z";
            // 
            // Avg_X
            // 
            this.Avg_X.Text = "Avg X";
            // 
            // Avg_Y
            // 
            this.Avg_Y.Text = "Avg Y";
            // 
            // Avg_Z
            // 
            this.Avg_Z.Text = "Avg Z";
            // 
            // checkBoxOP
            // 
            this.checkBoxOP.AutoSize = true;
            this.checkBoxOP.Location = new System.Drawing.Point(100, 14);
            this.checkBoxOP.Name = "checkBoxOP";
            this.checkBoxOP.Size = new System.Drawing.Size(111, 16);
            this.checkBoxOP.TabIndex = 6;
            this.checkBoxOP.Text = "Show Object Plane";
            this.checkBoxOP.UseVisualStyleBackColor = true;
            this.checkBoxOP.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBoxBB
            // 
            this.checkBoxBB.AutoSize = true;
            this.checkBoxBB.Location = new System.Drawing.Point(6, 14);
            this.checkBoxBB.Name = "checkBoxBB";
            this.checkBoxBB.Size = new System.Drawing.Size(88, 16);
            this.checkBoxBB.TabIndex = 7;
            this.checkBoxBB.Text = "Bonding Box";
            this.checkBoxBB.UseVisualStyleBackColor = true;
            this.checkBoxBB.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBoxEROI
            // 
            this.checkBoxEROI.AutoSize = true;
            this.checkBoxEROI.Location = new System.Drawing.Point(3, 21);
            this.checkBoxEROI.Name = "checkBoxEROI";
            this.checkBoxEROI.Size = new System.Drawing.Size(73, 16);
            this.checkBoxEROI.TabIndex = 8;
            this.checkBoxEROI.Text = "Show ROI";
            this.checkBoxEROI.UseVisualStyleBackColor = true;
            this.checkBoxEROI.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(304, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 586);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.checkBox_EDL);
            this.groupBox5.Controls.Add(this.checkBox_Sphere);
            this.groupBox5.Controls.Add(this.checkBox_RTP);
            this.groupBox5.Controls.Add(this.checkBox_LTP);
            this.groupBox5.Controls.Add(this.checkBoxBP);
            this.groupBox5.Controls.Add(this.checkBoxAP);
            this.groupBox5.Controls.Add(this.checkBoxBB);
            this.groupBox5.Controls.Add(this.checkBoxOP);
            this.groupBox5.Location = new System.Drawing.Point(380, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 54);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // checkBox_LTP
            // 
            this.checkBox_LTP.AutoSize = true;
            this.checkBox_LTP.Location = new System.Drawing.Point(398, 14);
            this.checkBox_LTP.Name = "checkBox_LTP";
            this.checkBox_LTP.Size = new System.Drawing.Size(94, 16);
            this.checkBox_LTP.TabIndex = 10;
            this.checkBox_LTP.Text = "Local Top Pos.";
            this.checkBox_LTP.UseVisualStyleBackColor = true;
            this.checkBox_LTP.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBoxBP
            // 
            this.checkBoxBP.AutoSize = true;
            this.checkBoxBP.Location = new System.Drawing.Point(318, 14);
            this.checkBoxBP.Name = "checkBoxBP";
            this.checkBoxBP.Size = new System.Drawing.Size(74, 16);
            this.checkBoxBP.TabIndex = 9;
            this.checkBoxBP.Text = "Base Plane";
            this.checkBoxBP.UseVisualStyleBackColor = true;
            this.checkBoxBP.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBoxAP
            // 
            this.checkBoxAP.AutoSize = true;
            this.checkBoxAP.Location = new System.Drawing.Point(217, 14);
            this.checkBoxAP.Name = "checkBoxAP";
            this.checkBoxAP.Size = new System.Drawing.Size(95, 16);
            this.checkBoxAP.TabIndex = 8;
            this.checkBoxAP.Text = "Show Avg Pos.";
            this.checkBoxAP.UseVisualStyleBackColor = true;
            this.checkBoxAP.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.checkBoxEROI);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(371, 54);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            // 
            // checkBox_RTP
            // 
            this.checkBox_RTP.AutoSize = true;
            this.checkBox_RTP.Location = new System.Drawing.Point(6, 36);
            this.checkBox_RTP.Name = "checkBox_RTP";
            this.checkBox_RTP.Size = new System.Drawing.Size(115, 16);
            this.checkBox_RTP.TabIndex = 11;
            this.checkBox_RTP.Text = "Reference Top Pos.";
            this.checkBox_RTP.UseVisualStyleBackColor = true;
            this.checkBox_RTP.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBox_Sphere
            // 
            this.checkBox_Sphere.AutoSize = true;
            this.checkBox_Sphere.Location = new System.Drawing.Point(127, 36);
            this.checkBox_Sphere.Name = "checkBox_Sphere";
            this.checkBox_Sphere.Size = new System.Drawing.Size(56, 16);
            this.checkBox_Sphere.TabIndex = 12;
            this.checkBox_Sphere.Text = "Sphere";
            this.checkBox_Sphere.UseVisualStyleBackColor = true;
            this.checkBox_Sphere.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBox_EDL
            // 
            this.checkBox_EDL.AutoSize = true;
            this.checkBox_EDL.Location = new System.Drawing.Point(189, 36);
            this.checkBox_EDL.Name = "checkBox_EDL";
            this.checkBox_EDL.Size = new System.Drawing.Size(81, 16);
            this.checkBox_EDL.TabIndex = 13;
            this.checkBox_EDL.Text = "Enable EDL";
            this.checkBox_EDL.UseVisualStyleBackColor = true;
            this.checkBox_EDL.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChange);
            // 
            // checkBox_Spherefitting
            // 
            this.checkBox_Spherefitting.AutoSize = true;
            this.checkBox_Spherefitting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Spherefitting.Location = new System.Drawing.Point(61, 331);
            this.checkBox_Spherefitting.Name = "checkBox_Spherefitting";
            this.checkBox_Spherefitting.Size = new System.Drawing.Size(87, 16);
            this.checkBox_Spherefitting.TabIndex = 66;
            this.checkBox_Spherefitting.Text = "Sphere fitting";
            this.checkBox_Spherefitting.UseVisualStyleBackColor = true;
            // 
            // savePointCloudToolStripMenuItem
            // 
            this.savePointCloudToolStripMenuItem.Name = "savePointCloudToolStripMenuItem";
            this.savePointCloudToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePointCloudToolStripMenuItem.Text = "Save PointCloud";
            this.savePointCloudToolStripMenuItem.Click += new System.EventHandler(this.savePointCloudToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1259, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3D)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem LoadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel sourceViewerWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_objextract;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Area_to;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Area_from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Orientation_to;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Orientation_from;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Refrence_height_to;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Refrence_height_from;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Local_height_to;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Local_height_from;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Volume_to;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_Volume_from;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_Aspect_to;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_Aspect_ratio_from;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_Refrence_tilt_to;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Refrence_tilt_from;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_Loacl_tilt_to;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Loacl_tilt_from;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Length_to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Length_from;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Width_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Width_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_SuggestValue;
        private System.Windows.Forms.CheckBox cbContourReinforce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView ObjlistView;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Local_Height;
        private System.Windows.Forms.ColumnHeader Ref_Height;
        private System.Windows.Forms.ColumnHeader Orientation;
        private System.Windows.Forms.ColumnHeader Local_Tilt;
        private System.Windows.Forms.ColumnHeader Aspect_Ratio;
        private System.Windows.Forms.ColumnHeader Area;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ColumnHeader Top_X;
        private System.Windows.Forms.ColumnHeader Top_Y;
        private System.Windows.Forms.ColumnHeader Top_Z;
        private System.Windows.Forms.ColumnHeader Avg_X;
        private System.Windows.Forms.ColumnHeader Avg_Y;
        private System.Windows.Forms.ColumnHeader Avg_Z;
        private System.Windows.Forms.ColumnHeader Ref_Tilt;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxOP;
        private System.Windows.Forms.CheckBox checkBoxBB;
        private System.Windows.Forms.CheckBox checkBoxEROI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox_3D;
        private System.Windows.Forms.CheckBox checkBoxAP;
        private System.Windows.Forms.Button btn_Generator;
        private System.Windows.Forms.CheckBox checkBoxBP;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.CheckBox CB_ROI;
        private System.Windows.Forms.CheckBox checkBox_LTP;
        private System.Windows.Forms.CheckBox checkBox_Sphere;
        private System.Windows.Forms.CheckBox checkBox_RTP;
        private System.Windows.Forms.CheckBox checkBox_EDL;
        private System.Windows.Forms.CheckBox checkBox_Spherefitting;
        private System.Windows.Forms.ToolStripMenuItem savePointCloudToolStripMenuItem;
    }
}

