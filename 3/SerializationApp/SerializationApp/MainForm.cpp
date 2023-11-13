#include "MainForm.h"
#include "Trainyard.h"

#include <msclr\marshal_cppstd.h>

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

System::Void SerializationApp::MainForm::btn_Run_Click(System::Object ^sender, System::EventArgs ^e)
{
	std::string destination, trainNumber, depatureTime;
	msclr::interop::marshal_context context;
	
	destination = context.marshal_as<std::string>(tb_Destination->Text);
	trainNumber = context.marshal_as<std::string>(tb_TrainNumber->Text);
	depatureTime = context.marshal_as<std::string>(tb_DepatureTime->Text);

	Train train(destination, trainNumber, depatureTime);

	// Textbox problem
	if(cmb_SerializationFormat->SelectedText == "XML")
	{
		train.xmlSerialize(train, "xmlTrain");
	}
	else if(cmb_SerializationFormat->SelectedText == "Binary")
	{
		train.binarySerialize(train, "binTrain");
	}
	//else
	//{
	//	MessageBox::Show("Error", "error");
	//	Application::Exit();
	//}
}
