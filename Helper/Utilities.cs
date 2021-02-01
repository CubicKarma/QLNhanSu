using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QLNhanSu.Helper
{
    class Utilities
    {
        static Color baseButtonBackColor = SystemColors.Control;
        static Color activeButtonBackColor = Color.RoyalBlue;
        static Color baseButtonForeColor = Color.Black;
        static Color activeButtonForeColor = Color.White;
        public static DangNhap GetMainForm()
        {
            foreach (Form form in Application.OpenForms)
                if (form is DangNhap)
                    return (DangNhap)form;
            return null;
        }
        public static void setButtonState(bool bIsActive, ref Button btn)
        {
            if(bIsActive)
            {
                btn.BackColor = activeButtonBackColor;
                btn.ForeColor = activeButtonForeColor;
            }
            else
            {
                btn.BackColor = baseButtonBackColor;
                btn.ForeColor = baseButtonForeColor;
            }
        }
    }
    class Define
    {
        public const string addHelper = "\\Image\\add.png";
        public const string editHelper = "\\Image\\edit.png";
        public const string deleteHelper = "\\Image\\delete.png";
        public const string searchHelper = "\\Image\\search.png";
        //Datasourse (khac nhau)
        //DN: ADMIN\SQLEXPRESS
        public const string dataSource = @"Data Source=NAM\SQLEXPRESS;Initial Catalog=Quanlynhasu_3F;Integrated Security=True";
    }
}
