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
         this.theListView = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
         this.theTreeView.Size = new System.Drawing.Size(288, 714);
         this.theTreeView.TabIndex = 0;
         this.theTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterCheck);
         this.theTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTreeView_AfterSelect);
         // 
         // manifestSplitContainer
         // 
         this.manifestSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.manifestSplitContainer.Name = "manifestSplitContainer";
         // 
         // manifestSplitContainer.Panel1
         // 
         this.manifestSplitContainer.Panel1.Controls.Add(this.theTreeView);
         // 
         // manifestSplitContainer.Panel2
         // 
         this.manifestSplitContainer.Panel2.Controls.Add(this.theListView);
         this.manifestSplitContainer.Size = new System.Drawing.Size(639, 714);
         this.manifestSplitContainer.SplitterDistance = 288;
         this.manifestSplitContainer.TabIndex = 1;
         // 
         // theListView
         // 
         this.theListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this.theListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theListView.FullRowSelect = true;
         this.theListView.GridLines = true;
         this.theListView.Location = new System.Drawing.Point(0, 0);
         this.theListView.MultiSelect = false;
         this.theListView.Name = "theListView";
         this.theListView.Size = new System.Drawing.Size(347, 714);
         this.theListView.TabIndex = 0;
         this.theListView.UseCompatibleStateImageBehavior = false;
         this.theListView.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "Item";
         this.columnHeader1.Width = 190;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Count";
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
         this.manifestSplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView theTreeView;
      private System.Windows.Forms.SplitContainer manifestSplitContainer;
      private System.Windows.Forms.ListView theListView;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
   }
}
