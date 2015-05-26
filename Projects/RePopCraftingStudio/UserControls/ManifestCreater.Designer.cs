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
         this.SuspendLayout();
         // 
         // theTreeView
         // 
         this.theTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.theTreeView.CheckBoxes = true;
         this.theTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theTreeView.HideSelection = false;
         this.theTreeView.Location = new System.Drawing.Point(0, 0);
         this.theTreeView.Name = "theTreeView";
         this.theTreeView.ShowRootLines = false;
         this.theTreeView.Size = new System.Drawing.Size(639, 714);
         this.theTreeView.TabIndex = 0;
         this.theTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterCheck);
         this.theTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterSelect);
         // 
         // ManifestCreater
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.theTreeView);
         this.Name = "ManifestCreater";
         this.Size = new System.Drawing.Size(639, 714);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView theTreeView;
   }
}
