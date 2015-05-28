namespace RePopCraftingStudio.UserControls
{
   partial class ManifestCreater
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.theTreeView = new System.Windows.Forms.TreeView();
         this.manifestSplitContainer = new System.Windows.Forms.SplitContainer();
         this.manifestTextBox = new System.Windows.Forms.TextBox();
         this.manifestSplitContainer.Panel1.SuspendLayout();
         this.manifestSplitContainer.Panel2.SuspendLayout();
         this.manifestSplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // theTreeView
         // 
         this.theTreeView.BackColor = System.Drawing.SystemColors.Window;
         this.theTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.theTreeView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.theTreeView.HideSelection = false;
         this.theTreeView.Location = new System.Drawing.Point(0, 0);
         this.theTreeView.Name = "theTreeView";
         this.theTreeView.ShowNodeToolTips = true;
         this.theTreeView.ShowRootLines = false;
         this.theTreeView.Size = new System.Drawing.Size(639, 374);
         this.theTreeView.TabIndex = 0;
         this.theTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterCheck);
         this.theTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterSelect);
         // 
         // manifestSplitContainer
         // 
         this.manifestSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.manifestSplitContainer.Name = "manifestSplitContainer";
         this.manifestSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // manifestSplitContainer.Panel1
         // 
         this.manifestSplitContainer.Panel1.Controls.Add(this.theTreeView);
         // 
         // manifestSplitContainer.Panel2
         // 
         this.manifestSplitContainer.Panel2.Controls.Add(this.manifestTextBox);
         this.manifestSplitContainer.Size = new System.Drawing.Size(639, 714);
         this.manifestSplitContainer.SplitterDistance = 374;
         this.manifestSplitContainer.TabIndex = 1;
         // 
         // manifestTextBox
         // 
         this.manifestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestTextBox.Location = new System.Drawing.Point(0, 0);
         this.manifestTextBox.Multiline = true;
         this.manifestTextBox.Name = "manifestTextBox";
         this.manifestTextBox.ReadOnly = true;
         this.manifestTextBox.Size = new System.Drawing.Size(639, 336);
         this.manifestTextBox.TabIndex = 0;
         this.manifestTextBox.WordWrap = false;
         // 
         // ManifestCreater
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.manifestSplitContainer);
         this.Name = "ManifestCreater";
         this.Size = new System.Drawing.Size(639, 714);
         this.manifestSplitContainer.Panel1.ResumeLayout(false);
         this.manifestSplitContainer.Panel2.ResumeLayout(false);
         this.manifestSplitContainer.Panel2.PerformLayout();
         this.manifestSplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView theTreeView;
      private System.Windows.Forms.SplitContainer manifestSplitContainer;
      private System.Windows.Forms.TextBox manifestTextBox;
   }
}
