namespace RePopCraftingStudio.Dialogs
{
   partial class OptionsDialog
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
         this.okButton = new System.Windows.Forms.Button();
         this.cancelButton = new System.Windows.Forms.Button();
         this.theTabControl = new System.Windows.Forms.TabControl();
         this.manifestTreeTabPage = new System.Windows.Forms.TabPage();
         this.theColorDialog = new System.Windows.Forms.ColorDialog();
         this.theTabControl.SuspendLayout();
         this.SuspendLayout();
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.okButton.Location = new System.Drawing.Point(191, 281);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 0;
         this.okButton.Text = "OK";
         this.okButton.UseVisualStyleBackColor = true;
         // 
         // cancelButton
         // 
         this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.cancelButton.Location = new System.Drawing.Point(272, 281);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 1;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         // 
         // theTabControl
         // 
         this.theTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.theTabControl.Controls.Add(this.manifestTreeTabPage);
         this.theTabControl.Location = new System.Drawing.Point(2, 2);
         this.theTabControl.Name = "theTabControl";
         this.theTabControl.SelectedIndex = 0;
         this.theTabControl.Size = new System.Drawing.Size(357, 273);
         this.theTabControl.TabIndex = 2;
         // 
         // manifestTreeTabPage
         // 
         this.manifestTreeTabPage.Location = new System.Drawing.Point(4, 22);
         this.manifestTreeTabPage.Name = "manifestTreeTabPage";
         this.manifestTreeTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.manifestTreeTabPage.Size = new System.Drawing.Size(349, 247);
         this.manifestTreeTabPage.TabIndex = 0;
         this.manifestTreeTabPage.Text = "Manifest Tree";
         this.manifestTreeTabPage.UseVisualStyleBackColor = true;
         // 
         // OptionsDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(359, 316);
         this.ControlBox = false;
         this.Controls.Add(this.theTabControl);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.okButton);
         this.Name = "OptionsDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Options";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsDialog_FormClosing);
         this.Load += new System.EventHandler(this.OptionsDialog_Load);
         this.theTabControl.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TabControl theTabControl;
      private System.Windows.Forms.TabPage manifestTreeTabPage;
      private System.Windows.Forms.ColorDialog theColorDialog;
   }
}