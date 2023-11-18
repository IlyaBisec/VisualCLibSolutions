using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COM_WindApplication.com;

namespace COM_WindApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_CreateDoc_Click(object sender, EventArgs e)
        {
            ComWord comWord = new ComWord(tb_RecipientName.Text, tb_ProjectName.Text, tb_DepartmentName.Text, tb_CompanyName.Text,
                tb_SenderName.Text);

            comWord.createTemplate();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_Preview_Paint(object sender, PaintEventArgs e)
        {
           // DataContext = new mainClass();
           // подключить dll проект
        } 
    }
}
