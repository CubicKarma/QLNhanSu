using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Helper
{
    public partial class HelpPictureBox : UserControl
    {
        int currentActiveIndex = 0;
        public HelpPictureBox()
        {
            InitializeComponent();
        }

        public void setImage(string filename)
        {
            helperPic.Image = Image.FromFile(Application.StartupPath + filename);
            helperPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
