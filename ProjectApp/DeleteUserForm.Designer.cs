namespace ProjectApp
{
	partial class DeleteUserForm
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
			labelUserId = new Label();
			userIdTxt = new TextBox();
			buttonDelete = new Button();
			buttonBack = new Button();
			SuspendLayout();
			// 
			// labelUserId
			// 
			labelUserId.AutoSize = true;
			labelUserId.Location = new Point(35, 35);
			labelUserId.Name = "labelUserId";
			labelUserId.Size = new Size(44, 15);
			labelUserId.TabIndex = 0;
			labelUserId.Text = "User ID";
			// 
			// userIdTxt
			// 
			userIdTxt.Location = new Point(140, 31);
			userIdTxt.Name = "userIdTxt";
			userIdTxt.Size = new Size(233, 23);
			userIdTxt.TabIndex = 2;
			// 
			// buttonDelete
			// 
			buttonDelete.Location = new Point(230, 89);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(88, 27);
			buttonDelete.TabIndex = 4;
			buttonDelete.Text = "Delete";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonBack
			// 
			buttonBack.Location = new Point(35, 89);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new Size(88, 27);
			buttonBack.TabIndex = 5;
			buttonBack.Text = "Back";
			buttonBack.UseVisualStyleBackColor = true;
			buttonBack.Click += buttonBack_Click;
			// 
			// DeleteUserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(413, 131);
			Controls.Add(buttonBack);
			Controls.Add(buttonDelete);
			Controls.Add(userIdTxt);
			Controls.Add(labelUserId);
			Name = "DeleteUserForm";
			Text = "Delete User";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelUserId;
		private System.Windows.Forms.TextBox userIdTxt;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonBack;
	}
}
