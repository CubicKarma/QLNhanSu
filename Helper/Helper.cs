using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Helper
{
    public partial class Helper : Form
    {
        Button CurrentButton;
        public Helper()
        {
            InitializeComponent();
        }
        void btnClick(Button btn)
        {
            if (CurrentButton == null)
            {
                CurrentButton = btn;
                Utilities.setButtonState(true, ref CurrentButton);
                return;
            }
            if (CurrentButton == btn)
                return;
            Utilities.setButtonState(false, ref CurrentButton);
            CurrentButton = btn;
            Utilities.setButtonState(true, ref CurrentButton);
        }
        void setImage(string filename)
        {
            helpImage.Image = Image.FromFile(Application.StartupPath+filename);
            helpImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void addHelpBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            setImage(Define.addHelper);
        }

        private void editHelpBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            setImage(Define.editHelper);
        }

        private void deleteHelpBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            setImage(Define.deleteHelper);
        }

        private void searchHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            setImage(Define.searchHelper);
        }
    }
}
