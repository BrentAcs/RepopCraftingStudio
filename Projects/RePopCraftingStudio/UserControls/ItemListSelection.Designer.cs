namespace RePopCraftingStudio.UserControls
{
   partial class ItemListSelection
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
         this.selectionTabControl = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.itemsListView = new RePopCraftingStudio.UserControls.EntityListView();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.fittingsListView = new RePopCraftingStudio.UserControls.EntityListView();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.blueprintsListView = new RePopCraftingStudio.UserControls.EntityListView();
         this.panel1 = new System.Windows.Forms.Panel();
         this.searchTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.selectionTabControl.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // selectionTabControl
         // 
         this.selectionTabControl.Controls.Add(this.tabPage1);
         this.selectionTabControl.Controls.Add(this.tabPage2);
         this.selectionTabControl.Controls.Add(this.tabPage3);
         this.selectionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.selectionTabControl.Location = new System.Drawing.Point(0, 43);
         this.selectionTabControl.Name = "selectionTabControl";
         this.selectionTabControl.SelectedIndex = 0;
         this.selectionTabControl.Size = new System.Drawing.Size(377, 394);
         this.selectionTabControl.TabIndex = 1;
         this.selectionTabControl.SelectedIndexChanged += new System.EventHandler(this.selectionTabControl_SelectedIndexChanged);
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.itemsListView);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(369, 368);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Items";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // itemsListView
         // 
         this.itemsListView.AlternateLineItemColor = System.Drawing.Color.LightCyan;
         this.itemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.itemsListView.EntityType = null;
         this.itemsListView.FullRowSelect = true;
         this.itemsListView.HideSelection = false;
         this.itemsListView.Location = new System.Drawing.Point(3, 3);
         this.itemsListView.MultiSelect = false;
         this.itemsListView.Name = "itemsListView";
         this.itemsListView.Size = new System.Drawing.Size(363, 362);
         this.itemsListView.TabIndex = 0;
         this.itemsListView.UseCompatibleStateImageBehavior = false;
         this.itemsListView.View = System.Windows.Forms.View.Details;
         this.itemsListView.SelectedIndexChanged += new System.EventHandler(this.EntityListView_SelectedIndexChanged);
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.fittingsListView);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(369, 368);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Fittings";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // fittingsListView
         // 
         this.fittingsListView.AlternateLineItemColor = System.Drawing.Color.LightCyan;
         this.fittingsListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.fittingsListView.EntityType = null;
         this.fittingsListView.FullRowSelect = true;
         this.fittingsListView.HideSelection = false;
         this.fittingsListView.Location = new System.Drawing.Point(3, 3);
         this.fittingsListView.MultiSelect = false;
         this.fittingsListView.Name = "fittingsListView";
         this.fittingsListView.Size = new System.Drawing.Size(363, 362);
         this.fittingsListView.TabIndex = 0;
         this.fittingsListView.UseCompatibleStateImageBehavior = false;
         this.fittingsListView.View = System.Windows.Forms.View.Details;
         this.fittingsListView.SelectedIndexChanged += new System.EventHandler(this.EntityListView_SelectedIndexChanged);
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.blueprintsListView);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(369, 368);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Blueprints";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // blueprintsListView
         // 
         this.blueprintsListView.AlternateLineItemColor = System.Drawing.Color.LightCyan;
         this.blueprintsListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.blueprintsListView.EntityType = null;
         this.blueprintsListView.FullRowSelect = true;
         this.blueprintsListView.HideSelection = false;
         this.blueprintsListView.Location = new System.Drawing.Point(0, 0);
         this.blueprintsListView.MultiSelect = false;
         this.blueprintsListView.Name = "blueprintsListView";
         this.blueprintsListView.Size = new System.Drawing.Size(369, 368);
         this.blueprintsListView.TabIndex = 0;
         this.blueprintsListView.UseCompatibleStateImageBehavior = false;
         this.blueprintsListView.View = System.Windows.Forms.View.Details;
         this.blueprintsListView.SelectedIndexChanged += new System.EventHandler(this.EntityListView_SelectedIndexChanged);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.searchTextBox);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(377, 43);
         this.panel1.TabIndex = 2;
         // 
         // searchTextBox
         // 
         this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.searchTextBox.Location = new System.Drawing.Point(53, 12);
         this.searchTextBox.Name = "searchTextBox";
         this.searchTextBox.Size = new System.Drawing.Size(320, 20);
         this.searchTextBox.TabIndex = 1;
         this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(44, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Search:";
         // 
         // ItemListSelection
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.selectionTabControl);
         this.Controls.Add(this.panel1);
         this.Name = "ItemListSelection";
         this.Size = new System.Drawing.Size(377, 437);
         this.Load += new System.EventHandler(this.ItemListSelection_Load);
         this.selectionTabControl.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.tabPage3.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl selectionTabControl;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox searchTextBox;
      private System.Windows.Forms.Label label1;
      private EntityListView itemsListView;
      private EntityListView fittingsListView;
      private EntityListView blueprintsListView;
   }
}
