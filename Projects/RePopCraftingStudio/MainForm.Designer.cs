using RePopCraftingStudio.UserControls;

namespace RePopCraftingStudio
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
         this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
         this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
         this.theItemListSelection = new RePopCraftingStudio.UserControls.ItemListSelection();
         this.thePropertyGrid = new System.Windows.Forms.PropertyGrid();
         this.label2 = new System.Windows.Forms.Label();
         this.theTabControl = new System.Windows.Forms.TabControl();
         this.manifestTabPage = new System.Windows.Forms.TabPage();
         this.theManifestCreater = new RePopCraftingStudio.UserControls.ManifestCreater();
         this.gameViewTabPage = new System.Windows.Forms.TabPage();
         this.gameViewSplitContainer = new System.Windows.Forms.SplitContainer();
         this.recipeTreeView = new System.Windows.Forms.TreeView();
         this.recipeResultsListView = new RePopCraftingStudio.UserControls.EntityListView();
         this.orginalManifestTabPage = new System.Windows.Forms.TabPage();
         this.manifestViewSplitContainer = new System.Windows.Forms.SplitContainer();
         this.manifestTreeView = new System.Windows.Forms.TreeView();
         this.manifestTextBox = new System.Windows.Forms.TextBox();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.mainSplitContainer.Panel1.SuspendLayout();
         this.mainSplitContainer.Panel2.SuspendLayout();
         this.mainSplitContainer.SuspendLayout();
         this.leftSplitContainer.Panel1.SuspendLayout();
         this.leftSplitContainer.Panel2.SuspendLayout();
         this.leftSplitContainer.SuspendLayout();
         this.theTabControl.SuspendLayout();
         this.manifestTabPage.SuspendLayout();
         this.gameViewTabPage.SuspendLayout();
         this.gameViewSplitContainer.Panel1.SuspendLayout();
         this.gameViewSplitContainer.Panel2.SuspendLayout();
         this.gameViewSplitContainer.SuspendLayout();
         this.orginalManifestTabPage.SuspendLayout();
         this.manifestViewSplitContainer.Panel1.SuspendLayout();
         this.manifestViewSplitContainer.Panel2.SuspendLayout();
         this.manifestViewSplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainSplitContainer
         // 
         this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainSplitContainer.Location = new System.Drawing.Point(0, 49);
         this.mainSplitContainer.Name = "mainSplitContainer";
         // 
         // mainSplitContainer.Panel1
         // 
         this.mainSplitContainer.Panel1.Controls.Add(this.leftSplitContainer);
         // 
         // mainSplitContainer.Panel2
         // 
         this.mainSplitContainer.Panel2.Controls.Add(this.theTabControl);
         this.mainSplitContainer.Size = new System.Drawing.Size(1038, 719);
         this.mainSplitContainer.SplitterDistance = 348;
         this.mainSplitContainer.TabIndex = 3;
         // 
         // leftSplitContainer
         // 
         this.leftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.leftSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.leftSplitContainer.Name = "leftSplitContainer";
         this.leftSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // leftSplitContainer.Panel1
         // 
         this.leftSplitContainer.Panel1.Controls.Add(this.theItemListSelection);
         // 
         // leftSplitContainer.Panel2
         // 
         this.leftSplitContainer.Panel2.Controls.Add(this.thePropertyGrid);
         this.leftSplitContainer.Panel2.Controls.Add(this.label2);
         this.leftSplitContainer.Size = new System.Drawing.Size(348, 719);
         this.leftSplitContainer.SplitterDistance = 379;
         this.leftSplitContainer.TabIndex = 0;
         // 
         // theItemListSelection
         // 
         this.theItemListSelection.Db = null;
         this.theItemListSelection.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theItemListSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.theItemListSelection.Location = new System.Drawing.Point(0, 0);
         this.theItemListSelection.Margin = new System.Windows.Forms.Padding(4);
         this.theItemListSelection.Name = "theItemListSelection";
         this.theItemListSelection.Size = new System.Drawing.Size(348, 379);
         this.theItemListSelection.TabIndex = 0;
         this.theItemListSelection.EntitySelected += new System.EventHandler<RePopCraftingStudio.UserControls.EntitySelectedEventArgs>(this.theItemListSelection_EntitySelected);
         // 
         // thePropertyGrid
         // 
         this.thePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.thePropertyGrid.HelpVisible = false;
         this.thePropertyGrid.Location = new System.Drawing.Point(0, 13);
         this.thePropertyGrid.Name = "thePropertyGrid";
         this.thePropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
         this.thePropertyGrid.Size = new System.Drawing.Size(348, 323);
         this.thePropertyGrid.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Top;
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(102, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Debug Property Box";
         // 
         // theTabControl
         // 
         this.theTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
         this.theTabControl.Controls.Add(this.manifestTabPage);
         this.theTabControl.Controls.Add(this.gameViewTabPage);
         this.theTabControl.Controls.Add(this.orginalManifestTabPage);
         this.theTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theTabControl.Location = new System.Drawing.Point(0, 0);
         this.theTabControl.Name = "theTabControl";
         this.theTabControl.SelectedIndex = 0;
         this.theTabControl.Size = new System.Drawing.Size(686, 719);
         this.theTabControl.TabIndex = 2;
         // 
         // manifestTabPage
         // 
         this.manifestTabPage.Controls.Add(this.theManifestCreater);
         this.manifestTabPage.Location = new System.Drawing.Point(4, 4);
         this.manifestTabPage.Name = "manifestTabPage";
         this.manifestTabPage.Size = new System.Drawing.Size(678, 693);
         this.manifestTabPage.TabIndex = 2;
         this.manifestTabPage.Text = "Manifest";
         this.manifestTabPage.UseVisualStyleBackColor = true;
         // 
         // theManifestCreater
         // 
         this.theManifestCreater.Db = null;
         this.theManifestCreater.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theManifestCreater.Location = new System.Drawing.Point(0, 0);
         this.theManifestCreater.Name = "theManifestCreater";
         this.theManifestCreater.Size = new System.Drawing.Size(678, 693);
         this.theManifestCreater.TabIndex = 0;
         this.theManifestCreater.EntitySelected += new System.EventHandler<RePopCraftingStudio.UserControls.EntitySelectedEventArgs>(this.theManifestCreater_EntitySelected);
         // 
         // gameViewTabPage
         // 
         this.gameViewTabPage.Controls.Add(this.gameViewSplitContainer);
         this.gameViewTabPage.Location = new System.Drawing.Point(4, 4);
         this.gameViewTabPage.Name = "gameViewTabPage";
         this.gameViewTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.gameViewTabPage.Size = new System.Drawing.Size(678, 693);
         this.gameViewTabPage.TabIndex = 0;
         this.gameViewTabPage.Text = "Game View";
         this.gameViewTabPage.UseVisualStyleBackColor = true;
         // 
         // gameViewSplitContainer
         // 
         this.gameViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gameViewSplitContainer.Location = new System.Drawing.Point(3, 3);
         this.gameViewSplitContainer.Name = "gameViewSplitContainer";
         this.gameViewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // gameViewSplitContainer.Panel1
         // 
         this.gameViewSplitContainer.Panel1.Controls.Add(this.recipeTreeView);
         // 
         // gameViewSplitContainer.Panel2
         // 
         this.gameViewSplitContainer.Panel2.Controls.Add(this.recipeResultsListView);
         this.gameViewSplitContainer.Size = new System.Drawing.Size(672, 687);
         this.gameViewSplitContainer.SplitterDistance = 321;
         this.gameViewSplitContainer.TabIndex = 1;
         // 
         // recipeTreeView
         // 
         this.recipeTreeView.BackColor = System.Drawing.SystemColors.Window;
         this.recipeTreeView.CheckBoxes = true;
         this.recipeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.recipeTreeView.Location = new System.Drawing.Point(0, 0);
         this.recipeTreeView.Name = "recipeTreeView";
         this.recipeTreeView.Size = new System.Drawing.Size(672, 321);
         this.recipeTreeView.TabIndex = 0;
         this.recipeTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.recipeTreeView_AfterSelect);
         // 
         // recipeResultsListView
         // 
         this.recipeResultsListView.AlternateLineItemColor = System.Drawing.Color.LightCyan;
         this.recipeResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.recipeResultsListView.EntityType = null;
         this.recipeResultsListView.FullRowSelect = true;
         this.recipeResultsListView.HideSelection = false;
         this.recipeResultsListView.Location = new System.Drawing.Point(0, 0);
         this.recipeResultsListView.MultiSelect = false;
         this.recipeResultsListView.Name = "recipeResultsListView";
         this.recipeResultsListView.Size = new System.Drawing.Size(672, 362);
         this.recipeResultsListView.TabIndex = 0;
         this.recipeResultsListView.UseCompatibleStateImageBehavior = false;
         this.recipeResultsListView.View = System.Windows.Forms.View.Details;
         this.recipeResultsListView.SelectedIndexChanged += new System.EventHandler(this.recipeResultsListView_SelectedIndexChanged);
         // 
         // orginalManifestTabPage
         // 
         this.orginalManifestTabPage.Controls.Add(this.manifestViewSplitContainer);
         this.orginalManifestTabPage.Location = new System.Drawing.Point(4, 4);
         this.orginalManifestTabPage.Name = "orginalManifestTabPage";
         this.orginalManifestTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.orginalManifestTabPage.Size = new System.Drawing.Size(678, 693);
         this.orginalManifestTabPage.TabIndex = 1;
         this.orginalManifestTabPage.Text = "(Orig) Manifest";
         this.orginalManifestTabPage.UseVisualStyleBackColor = true;
         // 
         // manifestViewSplitContainer
         // 
         this.manifestViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestViewSplitContainer.Location = new System.Drawing.Point(3, 3);
         this.manifestViewSplitContainer.Name = "manifestViewSplitContainer";
         this.manifestViewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // manifestViewSplitContainer.Panel1
         // 
         this.manifestViewSplitContainer.Panel1.Controls.Add(this.manifestTreeView);
         // 
         // manifestViewSplitContainer.Panel2
         // 
         this.manifestViewSplitContainer.Panel2.Controls.Add(this.manifestTextBox);
         this.manifestViewSplitContainer.Size = new System.Drawing.Size(672, 687);
         this.manifestViewSplitContainer.SplitterDistance = 413;
         this.manifestViewSplitContainer.TabIndex = 0;
         // 
         // manifestTreeView
         // 
         this.manifestTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestTreeView.Location = new System.Drawing.Point(0, 0);
         this.manifestTreeView.Name = "manifestTreeView";
         this.manifestTreeView.Size = new System.Drawing.Size(672, 413);
         this.manifestTreeView.TabIndex = 0;
         this.manifestTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.manifestTreeView_AfterSelect);
         // 
         // manifestTextBox
         // 
         this.manifestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestTextBox.Location = new System.Drawing.Point(0, 0);
         this.manifestTextBox.Multiline = true;
         this.manifestTextBox.Name = "manifestTextBox";
         this.manifestTextBox.ReadOnly = true;
         this.manifestTextBox.Size = new System.Drawing.Size(672, 270);
         this.manifestTextBox.TabIndex = 0;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
         this.menuStrip1.TabIndex = 4;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // toolStrip1
         // 
         this.toolStrip1.Location = new System.Drawing.Point(0, 24);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(1038, 25);
         this.toolStrip1.TabIndex = 5;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1038, 768);
         this.Controls.Add(this.mainSplitContainer);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainForm";
         this.Text = "The Repopulation (TM) - Crafting Studio";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.mainSplitContainer.Panel1.ResumeLayout(false);
         this.mainSplitContainer.Panel2.ResumeLayout(false);
         this.mainSplitContainer.ResumeLayout(false);
         this.leftSplitContainer.Panel1.ResumeLayout(false);
         this.leftSplitContainer.Panel2.ResumeLayout(false);
         this.leftSplitContainer.Panel2.PerformLayout();
         this.leftSplitContainer.ResumeLayout(false);
         this.theTabControl.ResumeLayout(false);
         this.manifestTabPage.ResumeLayout(false);
         this.gameViewTabPage.ResumeLayout(false);
         this.gameViewSplitContainer.Panel1.ResumeLayout(false);
         this.gameViewSplitContainer.Panel2.ResumeLayout(false);
         this.gameViewSplitContainer.ResumeLayout(false);
         this.orginalManifestTabPage.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel1.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel2.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel2.PerformLayout();
         this.manifestViewSplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.PropertyGrid thePropertyGrid;
        private System.Windows.Forms.TreeView recipeTreeView;
        private System.Windows.Forms.SplitContainer gameViewSplitContainer;
        //private EntityListView recipeResultsListView;
        private System.Windows.Forms.TabControl theTabControl;
        private System.Windows.Forms.TabPage gameViewTabPage;
        private System.Windows.Forms.TabPage orginalManifestTabPage;
        private EntityListView recipeResultsListView;
        private System.Windows.Forms.SplitContainer manifestViewSplitContainer;
        private System.Windows.Forms.TreeView manifestTreeView;
        private System.Windows.Forms.TextBox manifestTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private ItemListSelection theItemListSelection;
        private System.Windows.Forms.TabPage manifestTabPage;
        private ManifestCreater theManifestCreater;

    }
}

