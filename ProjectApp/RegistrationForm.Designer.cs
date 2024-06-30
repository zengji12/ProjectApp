namespace ProjectApp
{
	partial class RegistrationForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelAlamat;
		private System.Windows.Forms.TextBox idTxt;
		private System.Windows.Forms.TextBox nameTxt;
		private System.Windows.Forms.TextBox usernameTxt;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.TextBox alamatTxt;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Button buttonBack; // Add the Back button

		private void InitializeComponent()
		{
			labelId = new System.Windows.Forms.Label();
			labelName = new System.Windows.Forms.Label();
			labelUsername = new System.Windows.Forms.Label();
			labelPassword = new System.Windows.Forms.Label();
			labelAlamat = new System.Windows.Forms.Label();
			idTxt = new System.Windows.Forms.TextBox();
			nameTxt = new System.Windows.Forms.TextBox();
			usernameTxt = new System.Windows.Forms.TextBox();
			passwordTxt = new System.Windows.Forms.TextBox();
			alamatTxt = new System.Windows.Forms.TextBox();
			buttonRegister = new System.Windows.Forms.Button();
			buttonBack = new System.Windows.Forms.Button(); // Initialize the Back button

			SuspendLayout();

			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new System.Drawing.Point(35, 35);
			labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelId.Name = "labelId";
			labelId.Size = new System.Drawing.Size(18, 15);
			labelId.TabIndex = 0;
			labelId.Text = "ID";

			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new System.Drawing.Point(35, 81);
			labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelName.Name = "labelName";
			labelName.Size = new System.Drawing.Size(39, 15);
			labelName.TabIndex = 1;
			labelName.Text = "Name";

			// 
			// labelUsername
			// 
			labelUsername.AutoSize = true;
			labelUsername.Location = new System.Drawing.Point(35, 127);
			labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new System.Drawing.Size(60, 15);
			labelUsername.TabIndex = 2;
			labelUsername.Text = "Username";

			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Location = new System.Drawing.Point(35, 173);
			labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new System.Drawing.Size(57, 15);
			labelPassword.TabIndex = 3;
			labelPassword.Text = "Password";

			// 
			// labelAlamat
			// 
			labelAlamat.AutoSize = true;
			labelAlamat.Location = new System.Drawing.Point(35, 219);
			labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelAlamat.Name = "labelAlamat";
			labelAlamat.Size = new System.Drawing.Size(45, 15);
			labelAlamat.TabIndex = 4;
			labelAlamat.Text = "Alamat";

			// 
			// idTxt
			// 
			idTxt.Location = new System.Drawing.Point(140, 31);
			idTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			idTxt.Name = "idTxt";
			idTxt.Size = new System.Drawing.Size(233, 23);
			idTxt.TabIndex = 5;

			// 
			// nameTxt
			// 
			nameTxt.Location = new System.Drawing.Point(140, 77);
			nameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			nameTxt.Name = "nameTxt";
			nameTxt.Size = new System.Drawing.Size(233, 23);
			nameTxt.TabIndex = 6;

			// 
			// usernameTxt
			// 
			usernameTxt.Location = new System.Drawing.Point(140, 123);
			usernameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			usernameTxt.Name = "usernameTxt";
			usernameTxt.Size = new System.Drawing.Size(233, 23);
			usernameTxt.TabIndex = 7;

			// 
			// passwordTxt
			// 
			passwordTxt.Location = new System.Drawing.Point(140, 170);
			passwordTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.Size = new System.Drawing.Size(233, 23);
			passwordTxt.TabIndex = 8;
			passwordTxt.UseSystemPasswordChar = true;

			// 
			// alamatTxt
			// 
			alamatTxt.Location = new System.Drawing.Point(140, 216);
			alamatTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			alamatTxt.Name = "alamatTxt";
			alamatTxt.Size = new System.Drawing.Size(233, 23);
			alamatTxt.TabIndex = 9;

			// 
			// buttonRegister
			// 
			buttonRegister.Location = new System.Drawing.Point(208, 265);
			buttonRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			buttonRegister.Name = "buttonRegister";
			buttonRegister.Size = new System.Drawing.Size(88, 27);
			buttonRegister.TabIndex = 10;
			buttonRegister.Text = "Register";
			buttonRegister.UseVisualStyleBackColor = true;
			buttonRegister.Click += buttonRegister_Click;

			// 
			// buttonBack
			// 
			buttonBack.Location = new System.Drawing.Point(60, 265);
			buttonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new System.Drawing.Size(88, 27);
			buttonBack.TabIndex = 11;
			buttonBack.Text = "Back";
			buttonBack.UseVisualStyleBackColor = true;
			buttonBack.Click += buttonBack_Click;

			// 
			// RegistrationForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(413, 324);
			Controls.Add(buttonBack);
			Controls.Add(buttonRegister);
			Controls.Add(alamatTxt);
			Controls.Add(passwordTxt);
			Controls.Add(usernameTxt);
			Controls.Add(nameTxt);
			Controls.Add(idTxt);
			Controls.Add(labelAlamat);
			Controls.Add(labelPassword);
			Controls.Add(labelUsername);
			Controls.Add(labelName);
			Controls.Add(labelId);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "RegistrationForm";
			Text = "User Registration";
			ResumeLayout(false);
			PerformLayout();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		
	}
}
