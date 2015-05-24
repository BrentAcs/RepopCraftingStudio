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
         this.itemFilterTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.itemsListBox = new System.Windows.Forms.ListBox();
         this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
         this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
         this.thePropertyGrid = new System.Windows.Forms.PropertyGrid();
         this.theTabControl = new System.Windows.Forms.TabControl();
         this.gameViewTabPage = new System.Windows.Forms.TabPage();
         this.gameViewSplitContainer = new System.Windows.Forms.SplitContainer();
         this.recipeTreeView = new System.Windows.Forms.TreeView();
         this.manifestTabPage = new System.Windows.Forms.TabPage();
         this.manifestViewSplitContainer = new System.Windows.Forms.SplitContainer();
         this.manifestTreeView = new System.Windows.Forms.TreeView();
         this.recipeResultsListView = new RePopCraftingStudio.UserControls.EntityListView();
         this.manifestTextBox = new System.Windows.Forms.TextBox();
         this.mainSplitContainer.Panel1.SuspendLayout();
         this.mainSplitContainer.Panel2.SuspendLayout();
         this.mainSplitContainer.SuspendLayout();
         this.leftSplitContainer.Panel1.SuspendLayout();
         this.leftSplitContainer.Panel2.SuspendLayout();
         this.leftSplitContainer.SuspendLayout();
         this.theTabControl.SuspendLayout();
         this.gameViewTabPage.SuspendLayout();
         this.gameViewSplitContainer.Panel1.SuspendLayout();
         this.gameViewSplitContainer.Panel2.SuspendLayout();
         this.gameViewSplitContainer.SuspendLayout();
         this.manifestTabPage.SuspendLayout();
         this.manifestViewSplitContainer.Panel1.SuspendLayout();
         this.manifestViewSplitContainer.Panel2.SuspendLayout();
         this.manifestViewSplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // itemFilterTextBox
         // 
         this.itemFilterTextBox.Dock = System.Windows.Forms.DockStyle.Top;
         this.itemFilterTextBox.Location = new System.Drawing.Point(0, 13);
         this.itemFilterTextBox.Name = "itemFilterTextBox";
         this.itemFilterTextBox.Size = new System.Drawing.Size(304, 20);
         this.itemFilterTextBox.TabIndex = 0;
         this.itemFilterTextBox.TextChanged += new System.EventHandler(this.itemFilterTextBox_TextChanged);
         this.itemFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemFilterTextBox_KeyUp);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Top;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(30, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Item:";
         // 
         // itemsListBox
         // 
         this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.itemsListBox.FormattingEnabled = true;
         this.itemsListBox.Location = new System.Drawing.Point(0, 33);
         this.itemsListBox.Name = "itemsListBox";
         this.itemsListBox.Size = new System.Drawing.Size(304, 311);
         this.itemsListBox.TabIndex = 2;
         this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
         // 
         // mainSplitContainer
         // 
         this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.mainSplitContainer.Name = "mainSplitContainer";
         // 
         // mainSplitContainer.Panel1
         // 
         this.mainSplitContainer.Panel1.Controls.Add(this.leftSplitContainer);
         // 
         // mainSplitContainer.Panel2
         // 
         this.mainSplitContainer.Panel2.Controls.Add(this.theTabControl);
         this.mainSplitContainer.Size = new System.Drawing.Size(852, 651);
         this.mainSplitContainer.SplitterDistance = 304;
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
         this.leftSplitContainer.Panel1.Controls.Add(this.itemsListBox);
         this.leftSplitContainer.Panel1.Controls.Add(this.itemFilterTextBox);
         this.leftSplitContainer.Panel1.Controls.Add(this.label1);
         // 
         // leftSplitContainer.Panel2
         // 
         this.leftSplitContainer.Panel2.Controls.Add(this.thePropertyGrid);
         this.leftSplitContainer.Size = new System.Drawing.Size(304, 651);
         this.leftSplitContainer.SplitterDistance = 344;
         this.leftSplitContainer.TabIndex = 0;
         // 
         // thePropertyGrid
         // 
         this.thePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.thePropertyGrid.HelpVisible = false;
         this.thePropertyGrid.Location = new System.Drawing.Point(0, 0);
         this.thePropertyGrid.Name = "thePropertyGrid";
         this.thePropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
         this.thePropertyGrid.Size = new System.Drawing.Size(304, 303);
         this.thePropertyGrid.TabIndex = 0;
         // 
         // theTabControl
         // 
         this.theTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
         this.theTabControl.Controls.Add(this.gameViewTabPage);
         this.theTabControl.Controls.Add(this.manifestTabPage);
         this.theTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theTabControl.Location = new System.Drawing.Point(0, 0);
         this.theTabControl.Name = "theTabControl";
         this.theTabControl.SelectedIndex = 0;
         this.theTabControl.Size = new System.Drawing.Size(544, 651);
         this.theTabControl.TabIndex = 2;
         // 
         // gameViewTabPage
         // 
         this.gameViewTabPage.Controls.Add(this.gameViewSplitContainer);
         this.gameViewTabPage.Location = new System.Drawing.Point(4, 4);
         this.gameViewTabPage.Name = "gameViewTabPage";
         this.gameViewTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.gameViewTabPage.Size = new System.Drawing.Size(536, 625);
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
         this.gameViewSplitContainer.Size = new System.Drawing.Size(530, 619);
         this.gameViewSplitContainer.SplitterDistance = 291;
         this.gameViewSplitContainer.TabIndex = 1;
         // 
         // recipeTreeView
         // 
         this.recipeTreeView.BackColor = System.Drawing.SystemColors.Window;
         this.recipeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.recipeTreeView.Location = new System.Drawing.Point(0, 0);
         this.recipeTreeView.Name = "recipeTreeView";
         this.recipeTreeView.Size = new System.Drawing.Size(530, 291);
         this.recipeTreeView.TabIndex = 0;
         this.recipeTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.recipeTreeView_AfterSelect);
         // 
         // manifestTabPage
         // 
         this.manifestTabPage.Controls.Add(this.manifestViewSplitContainer);
         this.manifestTabPage.Location = new System.Drawing.Point(4, 4);
         this.manifestTabPage.Name = "manifestTabPage";
         this.manifestTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.manifestTabPage.Size = new System.Drawing.Size(536, 625);
         this.manifestTabPage.TabIndex = 1;
         this.manifestTabPage.Text = "Manifest";
         this.manifestTabPage.UseVisualStyleBackColor = true;
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
         this.manifestViewSplitContainer.Size = new System.Drawing.Size(530, 619);
         this.manifestViewSplitContainer.SplitterDistance = 373;
         this.manifestViewSplitContainer.TabIndex = 0;
         // 
         // manifestTreeView
         // 
         this.manifestTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestTreeView.Location = new System.Drawing.Point(0, 0);
         this.manifestTreeView.Name = "manifestTreeView";
         this.manifestTreeView.Size = new System.Drawing.Size(530, 373);
         this.manifestTreeView.TabIndex = 0;
         this.manifestTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.manifestTreeView_AfterSelect);
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
         this.recipeResultsListView.Size = new System.Drawing.Size(530, 324);
         this.recipeResultsListView.TabIndex = 0;
         this.recipeResultsListView.UseCompatibleStateImageBehavior = false;
         this.recipeResultsListView.View = System.Windows.Forms.View.Details;
         this.recipeResultsListView.SelectedIndexChanged += new System.EventHandler(this.recipeResultsListView_SelectedIndexChanged);
         // 
         // manifestTextBox
         // 
         this.manifestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestTextBox.Location = new System.Drawing.Point(0, 0);
         this.manifestTextBox.Multiline = true;
         this.manifestTextBox.Name = "manifestTextBox";
         this.manifestTextBox.ReadOnly = true;
         this.manifestTextBox.Size = new System.Drawing.Size(530, 242);
         this.manifestTextBox.TabIndex = 0;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(852, 651);
         this.Controls.Add(this.mainSplitContainer);
         this.Name = "MainForm";
         this.Text = "MainForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.mainSplitContainer.Panel1.ResumeLayout(false);
         this.mainSplitContainer.Panel2.ResumeLayout(false);
         this.mainSplitContainer.ResumeLayout(false);
         this.leftSplitContainer.Panel1.ResumeLayout(false);
         this.leftSplitContainer.Panel1.PerformLayout();
         this.leftSplitContainer.Panel2.ResumeLayout(false);
         this.leftSplitContainer.ResumeLayout(false);
         this.theTabControl.ResumeLayout(false);
         this.gameViewTabPage.ResumeLayout(false);
         this.gameViewSplitContainer.Panel1.ResumeLayout(false);
         this.gameViewSplitContainer.Panel2.ResumeLayout(false);
         this.gameViewSplitContainer.ResumeLayout(false);
         this.manifestTabPage.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel1.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel2.ResumeLayout(false);
         this.manifestViewSplitContainer.Panel2.PerformLayout();
         this.manifestViewSplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox itemFilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.PropertyGrid thePropertyGrid;
        private System.Windows.Forms.TreeView recipeTreeView;
        private System.Windows.Forms.SplitContainer gameViewSplitContainer;
        //private EntityListView recipeResultsListView;
        private System.Windows.Forms.TabControl theTabControl;
        private System.Windows.Forms.TabPage gameViewTabPage;
        private System.Windows.Forms.TabPage manifestTabPage;
        private EntityListView recipeResultsListView;
        private System.Windows.Forms.SplitContainer manifestViewSplitContainer;
        private System.Windows.Forms.TreeView manifestTreeView;
        private System.Windows.Forms.TextBox manifestTextBox;

    }
}

