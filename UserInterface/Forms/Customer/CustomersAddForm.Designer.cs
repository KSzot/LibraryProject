namespace UserInterface.Forms.Customer
{
    partial class CustomersAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.userControlInputLastName = new BibliotekaKontrolki.UserControlInput();
            this.userControlInputFirstName = new BibliotekaKontrolki.UserControlInput();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.bindingSourceGender = new System.Windows.Forms.BindingSource(this.components);
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGender)).BeginInit();
            this.groupBoxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Klient";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.userControlInputLastName);
            this.groupBoxGeneral.Controls.Add(this.userControlInputFirstName);
            this.groupBoxGeneral.Controls.Add(this.textBoxAge);
            this.groupBoxGeneral.Controls.Add(this.labelAge);
            this.groupBoxGeneral.Controls.Add(this.comboBoxGender);
            this.groupBoxGeneral.Controls.Add(this.labelGender);
            this.groupBoxGeneral.Location = new System.Drawing.Point(12, 116);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(504, 205);
            this.groupBoxGeneral.TabIndex = 2;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Ogólne";
            // 
            // userControlInputLastName
            // 
            this.userControlInputLastName.CzcionkaLabel = BibliotekaKontrolki.UserControlInput.LabelFontStyle.Bold;
            this.userControlInputLastName.Location = new System.Drawing.Point(0, 66);
            this.userControlInputLastName.Name = "userControlInputLastName";
            this.userControlInputLastName.setPaddingLabel = new System.Windows.Forms.Padding(0, 0, 126, 0);
            this.userControlInputLastName.SetSizeLabel = new System.Drawing.Size(187, 13);
            this.userControlInputLastName.SetSizetextBox = new System.Drawing.Size(145, 22);
            this.userControlInputLastName.Size = new System.Drawing.Size(450, 36);
            this.userControlInputLastName.TabIndex = 7;
            this.userControlInputLastName.TekstInput = "";
            this.userControlInputLastName.TekstLabel = "Nazwisko";
            // 
            // userControlInputFirstName
            // 
            this.userControlInputFirstName.CzcionkaLabel = BibliotekaKontrolki.UserControlInput.LabelFontStyle.Bold;
            this.userControlInputFirstName.Location = new System.Drawing.Point(6, 21);
            this.userControlInputFirstName.Name = "userControlInputFirstName";
            this.userControlInputFirstName.setPaddingLabel = new System.Windows.Forms.Padding(0, 0, 152, 0);
            this.userControlInputFirstName.SetSizeLabel = new System.Drawing.Size(182, 13);
            this.userControlInputFirstName.SetSizetextBox = new System.Drawing.Size(145, 22);
            this.userControlInputFirstName.Size = new System.Drawing.Size(450, 36);
            this.userControlInputFirstName.TabIndex = 6;
            this.userControlInputFirstName.TekstInput = "";
            this.userControlInputFirstName.TekstLabel = "Imię";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(187, 153);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(145, 22);
            this.textBoxAge.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(7, 153);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 15);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Wiek";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DataSource = this.bindingSourceGender;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(187, 108);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(145, 22);
            this.comboBoxGender.TabIndex = 3;
            this.comboBoxGender.TextChanged += new System.EventHandler(this.comboBoxGender_TextChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(7, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(29, 15);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Płeć";
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Controls.Add(this.textBoxPhone);
            this.groupBoxContact.Controls.Add(this.labelPhone);
            this.groupBoxContact.Controls.Add(this.textBoxAddress);
            this.groupBoxContact.Controls.Add(this.labelAddress);
            this.groupBoxContact.Location = new System.Drawing.Point(12, 338);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Size = new System.Drawing.Size(332, 100);
            this.groupBoxContact.TabIndex = 3;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "Kontakt";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(163, 71);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(145, 22);
            this.textBoxPhone.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(7, 71);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 15);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Telefon";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(163, 31);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(145, 22);
            this.textBoxAddress.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(7, 31);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(39, 15);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Adres";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Image = global::UserInterface.Properties.Resources.save_32;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(415, 369);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 45);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = global::UserInterface.Properties.Resources.man64;
            this.pictureBoxTitle.Location = new System.Drawing.Point(667, 18);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(61, 75);
            this.pictureBoxTitle.TabIndex = 1;
            this.pictureBoxTitle.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::UserInterface.Properties.Resources.cancel_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(563, 369);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 45);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // errorProviderGender
            // 
            this.errorProviderGender.ContainerControl = this;
            // 
            // CustomersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxContact);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "CustomersAddForm";
            this.Text = "CustomersAddForm";
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGender)).EndInit();
            this.groupBoxContact.ResumeLayout(false);
            this.groupBoxContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource bindingSourceGender;
        private System.Windows.Forms.ErrorProvider errorProviderGender;
        private BibliotekaKontrolki.UserControlInput userControlInputLastName;
        private BibliotekaKontrolki.UserControlInput userControlInputFirstName;
    }
}