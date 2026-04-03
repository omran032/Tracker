using Dev_Note_Assistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tracker.واجهات
{
    public partial class FrmPublisher : Form
    {
        public FrmPublisher()
        {
            InitializeComponent();

            MyTools.MoveControl(Pnl, this);
        }

       

        private void PicClose_Click(object sender, EventArgs e) // زر إغلاق
        {
            this.Close();
        }

        private void btnLinkedin_Click(object sender, EventArgs e) // Linkedin زر 
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/omran-alkashef-ab55b8338?utm_source=share_via&utm_content=profile&utm_medium=member_android");
        }

        private void btnTelegram_Click(object sender, EventArgs e) // Telegram زر 
        {
            System.Diagnostics.Process.Start("https://t.me/OMRAN940KING");
        }
    }
}
