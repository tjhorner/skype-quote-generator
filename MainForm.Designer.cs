namespace WindowsFormsApplication1
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.CopyButton = new System.Windows.Forms.Button();
			this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
			this.AuthorTextBox = new System.Windows.Forms.TextBox();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.AuthorFullNameTextBox = new System.Windows.Forms.TextBox();
			this.MessageLabel = new System.Windows.Forms.Label();
			this.MessageTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CopyButton.Location = new System.Drawing.Point(417, 169);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(75, 23);
			this.CopyButton.TabIndex = 9;
			this.CopyButton.Text = "&Copy";
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButtonClick);
			// 
			// DateTextBox
			// 
			this.DateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DateTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DateTextBox.Location = new System.Drawing.Point(127, 171);
			this.DateTextBox.Mask = "00/00/0000 90:00";
			this.DateTextBox.Name = "DateTextBox";
			this.DateTextBox.Size = new System.Drawing.Size(100, 21);
			this.DateTextBox.TabIndex = 8;
			this.DateTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// AuthorTextBox
			// 
			this.AuthorTextBox.Location = new System.Drawing.Point(127, 12);
			this.AuthorTextBox.Name = "AuthorTextBox";
			this.AuthorTextBox.Size = new System.Drawing.Size(100, 20);
			this.AuthorTextBox.TabIndex = 1;
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.AuthorLabel.Location = new System.Drawing.Point(12, 15);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(48, 13);
			this.AuthorLabel.TabIndex = 0;
			this.AuthorLabel.Text = "&Author:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Author &Full Name:";
			// 
			// AuthorFullNameTextBox
			// 
			this.AuthorFullNameTextBox.Location = new System.Drawing.Point(127, 38);
			this.AuthorFullNameTextBox.Name = "AuthorFullNameTextBox";
			this.AuthorFullNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.AuthorFullNameTextBox.TabIndex = 3;
			// 
			// MessageLabel
			// 
			this.MessageLabel.AutoSize = true;
			this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MessageLabel.Location = new System.Drawing.Point(12, 67);
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Size = new System.Drawing.Size(61, 13);
			this.MessageLabel.TabIndex = 5;
			this.MessageLabel.Text = "&Message:";
			// 
			// MessageTextBox
			// 
			this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MessageTextBox.Location = new System.Drawing.Point(127, 64);
			this.MessageTextBox.Multiline = true;
			this.MessageTextBox.Name = "MessageTextBox";
			this.MessageTextBox.Size = new System.Drawing.Size(365, 101);
			this.MessageTextBox.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "&Date/Time:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label3.Location = new System.Drawing.Point(230, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "(Optional)";
			// 
			// MainForm
			// 
			this.AcceptButton = this.CopyButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 201);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MessageLabel);
			this.Controls.Add(this.MessageTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AuthorFullNameTextBox);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.AuthorTextBox);
			this.Controls.Add(this.DateTextBox);
			this.Controls.Add(this.CopyButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(520, 240);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Skype Quote Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CopyButton;
		private System.Windows.Forms.MaskedTextBox DateTextBox;
		private System.Windows.Forms.TextBox AuthorTextBox;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox AuthorFullNameTextBox;
		private System.Windows.Forms.Label MessageLabel;
		private System.Windows.Forms.TextBox MessageTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

