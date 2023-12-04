using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word =  Microsoft.Office.Interop.Word;

namespace COM_WindApplication.com
{
    // A class template that implements opening a Word application, 
    // creating a text message, saving a document and exiting Word
    internal class ComWord
    {
        public ComWord(String recipientName, String projectName, String departmentName,
            String companyName, String senderName,
            String defaultPathDocTemplate,
            String defaultNewFilePath) 
        {
            if(File.Exists(defaultPathDocTemplate))
            {
                m_recipientName = recipientName;
                m_projectName = projectName;
                m_departmentName = departmentName;
                m_companyName = companyName;
                m_senderName = senderName;

                m_defaultPathDocTemplate = defaultPathDocTemplate;
                m_defaultFilePath = defaultNewFilePath;
            }
            else
            {
                throw new ArgumentException("Update or change template file path in the options", "File not found");
            }
        }

        // Implementation of creating a text  message template from sender 
        // to recipient
        public void createTemplate() 
        {
            Word.Application wordapp = null;

            // Replacing fields
            var replace_items = new Dictionary<string, string>()
            {
                {"<recipientName>", m_recipientName},
                {"<projectName>", m_projectName},
                {"<departmentName>", m_departmentName},
                {"<companyName>", m_companyName},
                {"<senderName>", m_senderName},
            };

            try
            {
                wordapp = new Word.Application();
                wordapp.Documents.Open(m_defaultPathDocTemplate);
                
                Object missing = Type.Missing;

                foreach(var item in replace_items)
                {
                    Word.Find find = wordapp.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                // Saving a letter under your own name
                wordapp.ActiveDocument.SaveAs(m_defaultFilePath + "\\" + m_recipientName);
                wordapp.ActiveDocument.Close();

                MessageBox.Show("Default file path: " + m_defaultFilePath + m_recipientName, "The email was successfully created!");

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Create word template error"); }
            finally 
            {
                if (wordapp != null)
                {
                    wordapp.Quit();
                }
            } 
        }

        // I not racist, I just dont like C#

        private String m_recipientName = "";
        private String m_projectName = "";
        private String m_departmentName = "";
        private String m_companyName = "";
        private String m_senderName = "";

        private String m_defaultFilePath = "";
        private String m_defaultPathDocTemplate = "";



    }
}
