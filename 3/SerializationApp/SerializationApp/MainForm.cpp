#include "MainForm.h"
#include "Trainyard.h"

using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
int main(array<String ^> ^args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	SerializationApp::MainForm mainForm;
	Application::Run(% mainForm);
}

// Serializing user input into fields: 
// destination, train number, depature time
//
// With a choice of file format(.XML or .binary) 
// and display of the result in a text field
System::Void SerializationApp::MainForm::btn_Serialization_Click(System::Object ^sender, System::EventArgs ^e)
{
	convertNetToStdString();

	Train train(g_destination, g_trainNumber, g_depatureTime);

	if(cmb_SerializationFormat->SelectedIndex == 0)
	{
		train.xmlSerialize(train, "xmlTrain");

		// Load result to Memo textbox
		loadToMemo("xmlTrain.xml");
		clearTextBoxes();
	}
	else if(cmb_SerializationFormat->SelectedIndex == 1)
	{
		train.binarySerialize(train, "binTrain");

		loadToMemo("binTrain.binary");
		clearTextBoxes();
	}
	else
	{
		MessageBox::Show("Error", "error serializetion");
		clearTextBoxes();
		return;
	}
}

// Deserializing user input into fields: 
// destination, train number, depature time
//
// With a choice of file format(.XML or .binary), 
// display of the result in a text field and filling in fields previously entered by the user
System::Void SerializationApp::MainForm::btn_Deserialization_Click(System::Object ^sender, System::EventArgs ^e)
{
	clearTextBoxes();

	//std::string destination, trainNumber, depatureTime;

	Train train(g_destination, g_trainNumber, g_depatureTime);

	if (cmb_SerializationFormat->SelectedIndex == 0)
	{
		train.xmlDeserialize("xmlTrain");
		convertStdToNetString();

		loadToMemo("xmlTrain.xml");
	}
	else if (cmb_SerializationFormat->SelectedIndex == 1)
	{
		train.binaryDeserialize("binTrain");
		convertStdToNetString();

		loadToMemo("binTrain.binary");
	}
	else
	{
		MessageBox::Show("Error", "error deserializetion");
		return;
	}
}

// Converting std::string to System::String value
void SerializationApp::MainForm::convertNetToStdString()
{
	msclr::interop::marshal_context context;

	g_destination = context.marshal_as<std::string>(tb_Destination->Text);
	g_trainNumber = context.marshal_as<std::string>(tb_TrainNumber->Text);
	g_depatureTime = context.marshal_as<std::string>(tb_DepatureTime->Text);

}

// Converting System::String to std::string value
void SerializationApp::MainForm::convertStdToNetString()
{
	tb_Destination->Text = gcnew System::String(g_destination.c_str());
	tb_TrainNumber->Text = gcnew System::String(g_trainNumber.c_str());
	tb_DepatureTime->Text = gcnew System::String(g_depatureTime.c_str());
}

// Reading the result of serialization files and pasting into a memo
void SerializationApp::MainForm::loadToMemo(System::String^ name)
{
	tb_Memo->Text = System::IO::File::ReadAllText(name, System::Text::Encoding::Default);
}


void SerializationApp::MainForm::clearTextBoxes()
{
	tb_Destination->Text = "";
	tb_TrainNumber->Text = "";
	tb_DepatureTime->Text = "";
}


System::Void SerializationApp::MainForm::btn_Exit_Click(System::Object ^sender, System::EventArgs ^e)
{
	Application::Exit();
}
