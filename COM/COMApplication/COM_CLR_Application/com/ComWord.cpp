#include "ComWord.h"

void COM::WordApp::WordTemplate::openWord()
{
	try
	{
		//wordapp = new Word::Application();
		// word.Visible = true;
	}
	catch (const std::exception &)
	{
		// Alert message
	}
}

void COM::WordApp::WordTemplate::closeWord()
{
	// Object saveChanges = word.WdSaveOptions.WdPromtToSaveChanges;
	// Object originaFormat = word.WdOriginalFormat.WdWordDocument;
	// Object routeDocument = Type.Missing;

	// wordapp.Quit(ref saveChanges, ref originaFormat, ref routeDocument);
	// wordapp = null;
	// Close();
}
