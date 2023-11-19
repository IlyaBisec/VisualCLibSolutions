using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COM_WindApplication.com;
using Microsoft.Office.Interop.Word;

namespace COM_WindApplication
{
    public partial class MainForm : Form
    {
        private String thisName = "COM Application";


        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_CreateDoc_Click(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;

            ComWord comWord = new ComWord(tb_RecipientName.Text.ToString(), tb_ProjectName.Text.ToString(), tb_DepartmentName.Text.ToString(), tb_CompanyName.Text.ToString(),
                tb_SenderName.Text.ToString(), res.newTemplateDocPath, res.newDefaultFilePath);

            comWord.createTemplate();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pnl_Preview_Paint(object sender, PaintEventArgs e)
        {
            var res = Properties.Settings.Default;

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Word"])
            {
                // if checkbox true (advanced view)
                // Showing the process name + the process name
                this.Text = thisName + "Current proccess: Word " + ": " + previewHandlerHost.CurrentPreviewHandler.ToString();
                // Showing privew proccess
                previewHandlerHost.Open(res.demoTemplate);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + tb_RecipientName.Text + ".docx";

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Word"])
            {
                // if checkbox true (advanced view)
                // Showing the process name + the process name
                this.Text = thisName + "Current proccess: Word " + ": " + previewHandlerHost.CurrentPreviewHandler.ToString();

                // Showing privew proccess
                previewHandlerHost.Open(createdLastFile);
            }
        }
    }
}
