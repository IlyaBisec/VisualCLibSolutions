#pragma once
#include <string>
#include <msclr\marshal_cppstd.h>

namespace SerializationApp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MainForm
	/// </summary>

	// Global variables
	std::string g_destination, g_trainNumber, g_depatureTime;

	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label ^lb_Destination;
	protected:

	private: System::Windows::Forms::TextBox ^tb_Destination;
	private: System::Windows::Forms::ComboBox ^cmb_SerializationFormat;
	protected:

	protected:


	private: System::Windows::Forms::TextBox ^tb_TrainNumber;

	private: System::Windows::Forms::Label ^lb_TrainNumber;
	private: System::Windows::Forms::TextBox ^tb_DepatureTime;



	private: System::Windows::Forms::Label ^lb_DepatureTime;
	private: System::Windows::Forms::TextBox ^tb_Memo;
	private: System::Windows::Forms::Button ^btn_Serialization;


	private: System::Windows::Forms::Button ^btn_Exit;
	private: System::Windows::Forms::Button ^btn_Deserialization;





	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lb_Destination = (gcnew System::Windows::Forms::Label());
			this->tb_Destination = (gcnew System::Windows::Forms::TextBox());
			this->cmb_SerializationFormat = (gcnew System::Windows::Forms::ComboBox());
			this->tb_TrainNumber = (gcnew System::Windows::Forms::TextBox());
			this->lb_TrainNumber = (gcnew System::Windows::Forms::Label());
			this->tb_DepatureTime = (gcnew System::Windows::Forms::TextBox());
			this->lb_DepatureTime = (gcnew System::Windows::Forms::Label());
			this->tb_Memo = (gcnew System::Windows::Forms::TextBox());
			this->btn_Serialization = (gcnew System::Windows::Forms::Button());
			this->btn_Exit = (gcnew System::Windows::Forms::Button());
			this->btn_Deserialization = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// lb_Destination
			// 
			this->lb_Destination->AutoSize = true;
			this->lb_Destination->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lb_Destination->Location = System::Drawing::Point(12, 9);
			this->lb_Destination->Name = L"lb_Destination";
			this->lb_Destination->Size = System::Drawing::Size(86, 18);
			this->lb_Destination->TabIndex = 0;
			this->lb_Destination->Text = L"Destination:";
			// 
			// tb_Destination
			// 
			this->tb_Destination->Location = System::Drawing::Point(123, 7);
			this->tb_Destination->Name = L"tb_Destination";
			this->tb_Destination->Size = System::Drawing::Size(114, 20);
			this->tb_Destination->TabIndex = 1;
			// 
			// cmb_SerializationFormat
			// 
			this->cmb_SerializationFormat->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8, System::Drawing::FontStyle::Regular,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(204)));
			this->cmb_SerializationFormat->FormattingEnabled = true;
			this->cmb_SerializationFormat->Items->AddRange(gcnew cli::array< System::Object ^  >(2) { L"XML", L"Binary" });
			this->cmb_SerializationFormat->Location = System::Drawing::Point(12, 85);
			this->cmb_SerializationFormat->Name = L"cmb_SerializationFormat";
			this->cmb_SerializationFormat->Size = System::Drawing::Size(225, 21);
			this->cmb_SerializationFormat->TabIndex = 4;
			// 
			// tb_TrainNumber
			// 
			this->tb_TrainNumber->Location = System::Drawing::Point(123, 33);
			this->tb_TrainNumber->Name = L"tb_TrainNumber";
			this->tb_TrainNumber->Size = System::Drawing::Size(114, 20);
			this->tb_TrainNumber->TabIndex = 2;
			// 
			// lb_TrainNumber
			// 
			this->lb_TrainNumber->AutoSize = true;
			this->lb_TrainNumber->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lb_TrainNumber->Location = System::Drawing::Point(12, 35);
			this->lb_TrainNumber->Name = L"lb_TrainNumber";
			this->lb_TrainNumber->Size = System::Drawing::Size(99, 18);
			this->lb_TrainNumber->TabIndex = 3;
			this->lb_TrainNumber->Text = L"Train number:";
			// 
			// tb_DepatureTime
			// 
			this->tb_DepatureTime->Location = System::Drawing::Point(123, 59);
			this->tb_DepatureTime->Name = L"tb_DepatureTime";
			this->tb_DepatureTime->Size = System::Drawing::Size(114, 20);
			this->tb_DepatureTime->TabIndex = 3;
			// 
			// lb_DepatureTime
			// 
			this->lb_DepatureTime->AutoSize = true;
			this->lb_DepatureTime->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lb_DepatureTime->Location = System::Drawing::Point(12, 61);
			this->lb_DepatureTime->Name = L"lb_DepatureTime";
			this->lb_DepatureTime->Size = System::Drawing::Size(109, 18);
			this->lb_DepatureTime->TabIndex = 5;
			this->lb_DepatureTime->Text = L"Departure time:";
			// 
			// tb_Memo
			// 
			this->tb_Memo->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 7, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204), true));
			this->tb_Memo->Location = System::Drawing::Point(12, 202);
			this->tb_Memo->Multiline = true;
			this->tb_Memo->Name = L"tb_Memo";
			this->tb_Memo->Size = System::Drawing::Size(222, 202);
			this->tb_Memo->TabIndex = 5;
			// 
			// btn_Serialization
			// 
			this->btn_Serialization->Location = System::Drawing::Point(12, 112);
			this->btn_Serialization->Name = L"btn_Serialization";
			this->btn_Serialization->Size = System::Drawing::Size(225, 24);
			this->btn_Serialization->TabIndex = 8;
			this->btn_Serialization->Text = L"Serialization";
			this->btn_Serialization->UseVisualStyleBackColor = true;
			this->btn_Serialization->Click += gcnew System::EventHandler(this, &MainForm::btn_Serialization_Click);
			// 
			// btn_Exit
			// 
			this->btn_Exit->Location = System::Drawing::Point(12, 172);
			this->btn_Exit->Name = L"btn_Exit";
			this->btn_Exit->Size = System::Drawing::Size(225, 24);
			this->btn_Exit->TabIndex = 10;
			this->btn_Exit->Text = L"Exit";
			this->btn_Exit->UseVisualStyleBackColor = true;
			this->btn_Exit->Click += gcnew System::EventHandler(this, &MainForm::btn_Exit_Click);
			// 
			// btn_Deserialization
			// 
			this->btn_Deserialization->Location = System::Drawing::Point(12, 142);
			this->btn_Deserialization->Name = L"btn_Deserialization";
			this->btn_Deserialization->Size = System::Drawing::Size(225, 24);
			this->btn_Deserialization->TabIndex = 11;
			this->btn_Deserialization->Text = L"Deserialization";
			this->btn_Deserialization->UseVisualStyleBackColor = true;
			this->btn_Deserialization->Click += gcnew System::EventHandler(this, &MainForm::btn_Deserialization_Click);
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(252, 416);
			this->Controls->Add(this->btn_Deserialization);
			this->Controls->Add(this->btn_Exit);
			this->Controls->Add(this->btn_Serialization);
			this->Controls->Add(this->tb_Memo);
			this->Controls->Add(this->tb_DepatureTime);
			this->Controls->Add(this->lb_DepatureTime);
			this->Controls->Add(this->tb_TrainNumber);
			this->Controls->Add(this->lb_TrainNumber);
			this->Controls->Add(this->cmb_SerializationFormat);
			this->Controls->Add(this->tb_Destination);
			this->Controls->Add(this->lb_Destination);
			this->Name = L"MainForm";
			this->Text = L"Serialization app";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btn_Exit_Click(System::Object ^sender, System::EventArgs ^e);
	private: System::Void btn_Serialization_Click(System::Object ^sender, System::EventArgs ^e);
	private: System::Void btn_Deserialization_Click(System::Object ^sender, System::EventArgs ^e);

	private: void convertStdToNetString();
	private: void convertNetToStdString();

	private: void loadToMemo(System::String ^name);
	private: void clearTextBoxes();
	


};


}
