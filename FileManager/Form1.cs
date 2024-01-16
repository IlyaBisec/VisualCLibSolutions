using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_AboutFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();

                if (openFile.ShowDialog() == DialogResult.Cancel)
                    return;

                FileInfo fileInfo = new FileInfo(openFile.FileName);
           

                tb_Memo.Text = "Имя файла: " + fileInfo.Name + Environment.NewLine;
                tb_Memo.Text += "Расширение файла: " + fileInfo.Extension + Environment.NewLine;
                tb_Memo.Text += "Размер файла: " + fileInfo.Length + " байт" + Environment.NewLine;
                tb_Memo.Text += "Дата создания: " + fileInfo.CreationTime + Environment.NewLine;
                tb_Memo.Text += "Дата последнего доступа: " + fileInfo.LastAccessTime + Environment.NewLine;
                tb_Memo.Text += "Дата последнего изменения: " + fileInfo.LastWriteTime + Environment.NewLine;
            }
            catch(Exception ex) { MessageBox.Show("error", ex.Message, MessageBoxButtons.OK); }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = openFileDialog.FileName;

                tb_Memo2.Text = System.IO.File.ReadAllText(filename);
                MessageBox.Show("File opened");
            }
            catch (Exception ex) { MessageBox.Show("error", ex.Message, MessageBoxButtons.OK); }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = saveFileDialog.FileName;

                System.IO.File.WriteAllText(filename, tb_Memo2.Text);
                MessageBox.Show("File saved");
            }
            catch (Exception ex) { MessageBox.Show("error", ex.Message, MessageBoxButtons.OK); }
        }
    }
}
