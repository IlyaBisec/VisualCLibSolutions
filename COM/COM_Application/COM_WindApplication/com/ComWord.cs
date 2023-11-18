using System;
using System.Collections.Generic;
using System.Linq;
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
            String defaultPathDocTemplate = @"doc\DefaultTemplate.docx",
            String defaultNewFilePath = @"newdoc\") 
        {
            m_recipientName = recipientName;
            m_projectName = projectName;
            m_departmentName = departmentName;
            m_companyName = companyName;
            m_senderName = senderName;

            m_defaultPathDocTemplate = defaultPathDocTemplate;
            m_defaultFilePath = defaultNewFilePath;
        }
        public void openWord()
        {
            try
            {
                m_wordapp = new Word.Application();
                m_wordapp.Visible = true;
            }
            catch (Exception ex){ MessageBox.Show("Open Word Error", ex.ToString()); }
        }
        public void closeWord() 
        {
            try
            {
                Object saveChanges = Word.WdSaveOptions.wdPromptToSaveChanges;
                Object originalFormat = Word.WdOriginalFormat.wdWordDocument;
                Object routeDocument = Type.Missing;

                m_wordapp.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
                m_wordapp = null;
            }
            catch (Exception ex) { MessageBox.Show("Close Word Error", ex.ToString()); }

        }

        // Implementation of creating a text  message template from sender 
        // to recipient
        public void createTemplate() 
        {
            //openWord();

            var doc = m_wordapp.Documents.Open(m_defaultPathDocTemplate);
            var selection = m_wordapp.Selection;

            // Replacing fields
            selection.Find.Execute("<recipientName>", ReplaceWith: m_recipientName);
            selection.Find.Execute("<projectName>", ReplaceWith: m_projectName);
            selection.Find.Execute("<departmentName>", ReplaceWith: m_departmentName);
            selection.Find.Execute("<companyName>", ReplaceWith: m_companyName);
            selection.Find.Execute("<senderName>", ReplaceWith: m_senderName);

            // Saving a letter under your own name
            doc.SaveAs(m_defaultFilePath + m_recipientName);

            doc.Close();
            m_wordapp.Quit();

            MessageBox.Show("The email was successfully created!", "Default file path: " + m_defaultFilePath + m_recipientName);
            
        }

        // I not racist, I just dont like C#

        private String m_recipientName = "";
        private String m_projectName = "";
        private String m_departmentName = "";
        private String m_companyName = "";
        private String m_senderName = "";

        private String m_defaultFilePath = "";

        private String m_defaultPathDocTemplate = "";
        

        // Word variables
        Word.Application m_wordapp;
    }
}
