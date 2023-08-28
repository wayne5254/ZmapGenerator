using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZmapGenerator
{
    public partial class ResolutionForm : Form
    {
        public float rx;
        public float ry;
        public float rz;
        public int depthSelection;

        public ResolutionForm()
        {
            InitializeComponent();
            textBoxResX.Text = "1";
            textBoxResY.Text = "1";
            textBoxResZ.Text = "0.1";

            comboBoxDepth.SelectedIndex = 0;
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            rx = float.Parse(textBoxResX.Text, System.Globalization.CultureInfo.InvariantCulture);
            ry = float.Parse(textBoxResY.Text, System.Globalization.CultureInfo.InvariantCulture);
            rz = float.Parse(textBoxResZ.Text, System.Globalization.CultureInfo.InvariantCulture);

            depthSelection = comboBoxDepth.SelectedIndex;

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
