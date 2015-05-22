namespace RePopCraftingStudio.Dialogs
{
   partial class ExceptionDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.messageTextBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.stackTraceTextBox = new System.Windows.Forms.TextBox();
         this.showInnerButton = new System.Windows.Forms.Button();
         this.closeButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(53, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Message:";
         // 
         // messageTextBox
         // 
         this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.messageTextBox.Location = new System.Drawing.Point(71, 12);
         this.messageTextBox.Name = "messageTextBox";
         this.messageTextBox.ReadOnly = true;
         this.messageTextBox.Size = new System.Drawing.Size(307, 20);
         this.messageTextBox.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 42);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(69, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Stack Trace:";
         // 
         // stackTraceTextBox
         // 
         this.stackTraceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.stackTraceTextBox.Location = new System.Drawing.Point(15, 58);
         this.stackTraceTextBox.Multiline = true;
         this.stackTraceTextBox.Name = "stackTraceTextBox";
         this.stackTraceTextBox.ReadOnly = true;
         this.stackTraceTextBox.Size = new System.Drawing.Size(363, 216);
         this.stackTraceTextBox.TabIndex = 3;
         // 
         // showInnerButton
         // 
         this.showInnerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.showInnerButton.Location = new System.Drawing.Point(222, 280);
         this.showInnerButton.Name = "showInnerButton";
         this.showInnerButton.Size = new System.Drawing.Size(75, 23);
         this.showInnerButton.TabIndex = 4;
         this.showInnerButton.Text = "Show Inner";
         this.showInnerButton.UseVisualStyleBackColor = true;
         this.showInnerButton.Click += new System.EventHandler(this.showInnerButton_Click);
         // 
         // closeButton
         // 
         this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.closeButton.Location = new System.Drawing.Point(303, 280);
         this.closeButton.Name = "closeButton";
         this.closeButton.Size = new System.Drawing.Size(75, 23);
         this.closeButton.TabIndex = 5;
         this.closeButton.Text = "Close";
         this.closeButton.UseVisualStyleBackColor = true;
         // 
         // ExceptionDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(390, 315);
         this.Controls.Add(this.closeButton);
         this.Controls.Add(this.showInnerButton);
         this.Controls.Add(this.stackTraceTextBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.messageTextBox);
         this.Controls.Add(this.label1);
         this.Name = "ExceptionDialog";
         this.ShowIcon = false;
         this.Text = "Unhandled Exception";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExceptionDialog_FormClosed);
         this.Load += new System.EventHandler(this.ExceptionDialog_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox messageTextBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox stackTraceTextBox;
      private System.Windows.Forms.Button showInnerButton;
      private System.Windows.Forms.Button closeButton;
   }
}