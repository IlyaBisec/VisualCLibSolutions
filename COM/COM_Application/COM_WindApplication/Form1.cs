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

        // Creating document
        // Word Page
        private void btn_CreateDoc_Click(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;

            ComWord comWord = new ComWord(tb_RecipientName.Text.ToString(), tb_ProjectName.Text.ToString(), tb_DepartmentName.Text.ToString(), tb_CompanyName.Text.ToString(),
                tb_SenderName.Text.ToString(), res.newTemplateDocPath, res.newDefaultFilePath);

            comWord.createTemplate();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void pnl_Preview_Paint(object sender, PaintEventArgs e)
        {
            var res = Properties.Settings.Default;

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Word"])
            {
                showProccessInfo("Word");

                // Showing privew proccess
                previewHandlerHost.Open(res.demoTemplate);
            }
        }

        // Excel page
        private void pnl_PreviewExcel_Paint(object sender, PaintEventArgs e)
        {
            var res = Properties.Settings.Default;

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Excel"])
            {
                showProccessInfo("Excel");

                // Showing privew proccess
                previreHandleHostExcel.Open(res.demoExcelTemplate);
            }
        }

        private void btn_ExitExelApp_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Gets paths from resources
            var res = Properties.Settings.Default;

            tb_TemplateDocPath.Text = res.newTemplateDocPath;
            tb_NewDefFilePath.Text = res.newDefaultFilePath;
            tb_DemoTemplate.Text = res.demoTemplate;
            tb_DemoExcelTemplate.Text = res.demoExcelTemplate;

            chekb_TurnOffComboboxDictionary.Checked = res.manualInput;
        }

        // Settings page
        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + tb_RecipientName.Text + ".docx";

            if (tab_COM.SelectedTab == tab_COM.TabPages["tbp_Word"])
            {
                showProccessInfo("Word");

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

                lb_DemoExcelTemplate.Visible = true;
                tb_DemoExcelTemplate.Visible = true;
                btn_DemoExcelTemplate.Visible = true;

                res.advanceSettings = true;
            }
            else
            {
                lb_DemoTemplate.Visible = false;
                tb_DemoTemplate.Visible = false;
                btn_DemoTemplate.Visible = false;

                lb_DemoExcelTemplate.Visible = false;
                tb_DemoExcelTemplate.Visible = false;
                btn_DemoExcelTemplate.Visible = false;

                res.advanceSettings = false;
            }
        }

        private void chekb_TurnOffComboboxDictionary_CheckedChanged(object sender, EventArgs e)
        {
            var res = Properties.Settings.Default;

            if (chekb_TurnOffComboboxDictionary.Checked)
            {
                cmb_MonthName.Visible = false;
                cmb_NameRegion.Visible = false;

                tb_MonthName.Visible = true;
                tb_NameRegion.Visible = true;

                res.manualInput = true;
            }
            else
            {
                cmb_MonthName.Visible = true;
                cmb_NameRegion.Visible = true;

                tb_MonthName.Visible = false;
                tb_NameRegion.Visible = false;

                res.manualInput = false;
            }
        }

        // Sets new default resources path
        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.newTemplateDocPath = tb_TemplateDocPath.Text;
            Properties.Settings.Default.newDefaultFilePath = tb_NewDefFilePath.Text;
            Properties.Settings.Default.demoTemplate = tb_DemoTemplate.Text;
            Properties.Settings.Default.demoExcelTemplate = tb_DemoExcelTemplate.Text;

            Properties.Settings.Default.manualInput = chekb_TurnOffComboboxDictionary.Checked;
            Properties.Settings.Default.advanceSettings = chekb_AdvancedSettings.Checked;


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
        private void btn_DemoExcelTemplate_Click(object sender, EventArgs e)
        {
            changePathForFiles(tb_DemoExcelTemplate);
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

        // Additional functions
        // Showing the process name + the process name
        private void showProccessInfo(string preoccess_name)
        {
            if (chekb_AdvancedSettings.Checked)
            {
                this.Text = thisName + "Current proccess: " + preoccess_name + ": " + previewHandlerHost.CurrentPreviewHandler.ToString();
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
    }
}
