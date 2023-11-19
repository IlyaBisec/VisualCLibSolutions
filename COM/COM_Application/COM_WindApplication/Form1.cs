using System;
using System.Windows.Forms;
using COM_WindApplication.com;

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
                showProccessInfo();

                // Showing privew proccess
                previewHandlerHost.Open(res.demoTemplate);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Gets paths from resources
            var res = Properties.Settings.Default;

            tb_TemplateDocPath.Text = res.newTemplateDocPath;
            tb_NewDefFilePath.Text = res.newDefaultFilePath;
            tb_DemoTemplate.Text = res.demoTemplate;
        }

        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + tb_RecipientName.Text + ".docx";

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Word"])
            {
                showProccessInfo();

                // Showing privew proccess
                previewHandlerHost.Open(createdLastFile);
            }
        }

        private void chekb_AdvancedSettings_CheckedChanged(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;

            if (chekb_AdvancedSettings.Checked)
            {
                lb_DemoTemplate.Visible = true;
                tb_DemoTemplate.Visible = true;
                btn_DemoTemplate.Visible = true;

                res.advanceSettings = true;
            }
            else
            {
                lb_DemoTemplate.Visible = false;
                tb_DemoTemplate.Visible = false;
                btn_DemoTemplate.Visible = false;

                res.advanceSettings = false;
            }
        }

        // Showing the process name + the process name
        private void showProccessInfo()
        {
            if (chekb_AdvancedSettings.Checked)
            {
                this.Text = thisName + "Current proccess: Word " + ": " + previewHandlerHost.CurrentPreviewHandler.ToString();
            }
        }
        
        // Chanching default path for doc files
        private void changePathForFiles(TextBox changed_path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
      
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    changed_path.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Template file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sets new default resources path
        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.newTemplateDocPath = tb_TemplateDocPath.Text;
            Properties.Settings.Default.newDefaultFilePath = tb_NewDefFilePath.Text;
            Properties.Settings.Default.demoTemplate = tb_DemoTemplate.Text;

            Properties.Settings.Default.Save();
        }

        private void btn_TemplateDocPath_Click(object sender, EventArgs e)
        {
            changePathForFiles(tb_TemplateDocPath);
        }

        private void btn_DemoTemplate_Click(object sender, EventArgs e)
        {
            changePathForFiles(tb_DemoTemplate);
        }

        private void btn_NewDefFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            try
            {
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_NewDefFilePath.Text = browserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Template file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
