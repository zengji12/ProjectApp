namespace ProjectApp
{
	partial class OptionsForm
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
			reNewPassButton = new Button();
			deleteMeButton = new Button();
			backButton = new Button();
			SuspendLayout();
			// 
			// reNewPassButton
			// 
			reNewPassButton.Location = new Point(55, 22);
			reNewPassButton.Name = "reNewPassButton";
			reNewPassButton.Size = new Size(92, 50);
			reNewPassButton.TabIndex = 0;
			reNewPassButton.Text = "Change Password";
			reNewPassButton.UseVisualStyleBackColor = true;
			reNewPassButton.Click += reNewPassButton_Click_1;
			// 
			// deleteMeButton
			// 
			deleteMeButton.Location = new Point(55, 88);
			deleteMeButton.Name = "deleteMeButton";
			deleteMeButton.Size = new Size(92, 50);
			deleteMeButton.TabIndex = 1;
			deleteMeButton.Text = "Delete Your Account";
			deleteMeButton.UseVisualStyleBackColor = true;
			deleteMeButton.Click += deleteMeButton_Click_1;
			// 
			// backButton
			// 
			backButton.Location = new Point(64, 144);
			backButton.Name = "backButton";
			backButton.Size = new Size(75, 28);
			backButton.TabIndex = 2;
			backButton.Text = "Back";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click_1;
			// 
			// OptionsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(219, 207);
			Controls.Add(backButton);
			Controls.Add(deleteMeButton);
			Controls.Add(reNewPassButton);
			Name = "OptionsForm";
			Text = "Options";
			ResumeLayout(false);
		}

		#endregion

		private Button reNewPassButton;
		private Button deleteMeButton;
		private Button backButton;
	}
}
