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
         this.label1 = new System.Windows.Forms.Label();
         this.theListView = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.label2 = new System.Windows.Forms.Label();
         this.legendPanel = new System.Windows.Forms.Panel();
         this.legendToggleButton = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.recipeSinglePanel = new System.Windows.Forms.Panel();
         this.label4 = new System.Windows.Forms.Label();
         this.recipeMultiplePnel = new System.Windows.Forms.Panel();
         this.label5 = new System.Windows.Forms.Label();
         this.ingredientGatheredPanel = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.agentGatheredPanel = new System.Windows.Forms.Panel();
         this.label7 = new System.Windows.Forms.Label();
         this.agentCraftedPanel = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.ingredientCraftedPanel = new System.Windows.Forms.Panel();
         this.label9 = new System.Windows.Forms.Label();
         this.agentComponentPanel = new System.Windows.Forms.Panel();
         this.label10 = new System.Windows.Forms.Label();
         this.manifestSplitContainer.Panel1.SuspendLayout();
         this.manifestSplitContainer.Panel2.SuspendLayout();
         this.manifestSplitContainer.SuspendLayout();
         this.legendPanel.SuspendLayout();
         this.recipeSinglePanel.SuspendLayout();
         this.recipeMultiplePnel.SuspendLayout();
         this.ingredientGatheredPanel.SuspendLayout();
         this.agentGatheredPanel.SuspendLayout();
         this.agentCraftedPanel.SuspendLayout();
         this.ingredientCraftedPanel.SuspendLayout();
         this.agentComponentPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // theTreeView
         // 
         this.theTreeView.BackColor = System.Drawing.SystemColors.Window;
         this.theTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.theTreeView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.theTreeView.HideSelection = false;
         this.theTreeView.Location = new System.Drawing.Point(0, 23);
         this.theTreeView.Name = "theTreeView";
         this.theTreeView.ShowNodeToolTips = true;
         this.theTreeView.ShowRootLines = false;
         this.theTreeView.Size = new System.Drawing.Size(376, 553);
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
         this.manifestSplitContainer.Panel1.Controls.Add(this.legendPanel);
         this.manifestSplitContainer.Panel1.Controls.Add(this.label1);
         // 
         // manifestSplitContainer.Panel2
         // 
         this.manifestSplitContainer.Panel2.Controls.Add(this.theListView);
         this.manifestSplitContainer.Panel2.Controls.Add(this.label2);
         this.manifestSplitContainer.Size = new System.Drawing.Size(639, 714);
         this.manifestSplitContainer.SplitterDistance = 376;
         this.manifestSplitContainer.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Top;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(376, 23);
         this.label1.TabIndex = 1;
         this.label1.Text = "Crafting Tree";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // theListView
         // 
         this.theListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this.theListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.theListView.FullRowSelect = true;
         this.theListView.GridLines = true;
         this.theListView.Location = new System.Drawing.Point(0, 23);
         this.theListView.MultiSelect = false;
         this.theListView.Name = "theListView";
         this.theListView.Size = new System.Drawing.Size(259, 691);
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
         // label2
         // 
         this.label2.Dock = System.Windows.Forms.DockStyle.Top;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(259, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Materials List";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // legendPanel
         // 
         this.legendPanel.Controls.Add(this.agentComponentPanel);
         this.legendPanel.Controls.Add(this.ingredientCraftedPanel);
         this.legendPanel.Controls.Add(this.agentCraftedPanel);
         this.legendPanel.Controls.Add(this.agentGatheredPanel);
         this.legendPanel.Controls.Add(this.ingredientGatheredPanel);
         this.legendPanel.Controls.Add(this.recipeMultiplePnel);
         this.legendPanel.Controls.Add(this.recipeSinglePanel);
         this.legendPanel.Controls.Add(this.label3);
         this.legendPanel.Controls.Add(this.legendToggleButton);
         this.legendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.legendPanel.Location = new System.Drawing.Point(0, 576);
         this.legendPanel.Name = "legendPanel";
         this.legendPanel.Size = new System.Drawing.Size(376, 138);
         this.legendPanel.TabIndex = 2;
         // 
         // legendToggleButton
         // 
         this.legendToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.legendToggleButton.Location = new System.Drawing.Point(324, 3);
         this.legendToggleButton.Name = "legendToggleButton";
         this.legendToggleButton.Size = new System.Drawing.Size(50, 23);
         this.legendToggleButton.TabIndex = 0;
         this.legendToggleButton.Text = "Hide";
         this.legendToggleButton.UseVisualStyleBackColor = true;
         this.legendToggleButton.Click += new System.EventHandler(this.legendToggleButton_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 8);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(46, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Legend:";
         // 
         // recipeSinglePanel
         // 
         this.recipeSinglePanel.BackColor = System.Drawing.Color.Maroon;
         this.recipeSinglePanel.Controls.Add(this.label4);
         this.recipeSinglePanel.Location = new System.Drawing.Point(6, 30);
         this.recipeSinglePanel.Name = "recipeSinglePanel";
         this.recipeSinglePanel.Size = new System.Drawing.Size(180, 20);
         this.recipeSinglePanel.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label4.Location = new System.Drawing.Point(0, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(180, 20);
         this.label4.TabIndex = 0;
         this.label4.Text = "Recipe, single";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // recipeMultiplePnel
         // 
         this.recipeMultiplePnel.BackColor = System.Drawing.Color.Maroon;
         this.recipeMultiplePnel.Controls.Add(this.label5);
         this.recipeMultiplePnel.Location = new System.Drawing.Point(6, 56);
         this.recipeMultiplePnel.Name = "recipeMultiplePnel";
         this.recipeMultiplePnel.Size = new System.Drawing.Size(180, 20);
         this.recipeMultiplePnel.TabIndex = 3;
         // 
         // label5
         // 
         this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label5.Location = new System.Drawing.Point(0, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(180, 20);
         this.label5.TabIndex = 0;
         this.label5.Text = "Recipe, multiple";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ingredientGatheredPanel
         // 
         this.ingredientGatheredPanel.BackColor = System.Drawing.Color.Maroon;
         this.ingredientGatheredPanel.Controls.Add(this.label6);
         this.ingredientGatheredPanel.Location = new System.Drawing.Point(6, 82);
         this.ingredientGatheredPanel.Name = "ingredientGatheredPanel";
         this.ingredientGatheredPanel.Size = new System.Drawing.Size(180, 20);
         this.ingredientGatheredPanel.TabIndex = 4;
         // 
         // label6
         // 
         this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label6.Location = new System.Drawing.Point(0, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(180, 20);
         this.label6.TabIndex = 0;
         this.label6.Text = "Ingredient, gathered";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // agentGatheredPanel
         // 
         this.agentGatheredPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentGatheredPanel.BackColor = System.Drawing.Color.Maroon;
         this.agentGatheredPanel.Controls.Add(this.label7);
         this.agentGatheredPanel.Location = new System.Drawing.Point(191, 30);
         this.agentGatheredPanel.Name = "agentGatheredPanel";
         this.agentGatheredPanel.Size = new System.Drawing.Size(180, 20);
         this.agentGatheredPanel.TabIndex = 5;
         // 
         // label7
         // 
         this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label7.Location = new System.Drawing.Point(0, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(180, 20);
         this.label7.TabIndex = 0;
         this.label7.Text = "Agent, gathered";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // agentCraftedPanel
         // 
         this.agentCraftedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentCraftedPanel.BackColor = System.Drawing.Color.Maroon;
         this.agentCraftedPanel.Controls.Add(this.label8);
         this.agentCraftedPanel.Location = new System.Drawing.Point(191, 56);
         this.agentCraftedPanel.Name = "agentCraftedPanel";
         this.agentCraftedPanel.Size = new System.Drawing.Size(180, 20);
         this.agentCraftedPanel.TabIndex = 6;
         // 
         // label8
         // 
         this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label8.Location = new System.Drawing.Point(0, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(180, 20);
         this.label8.TabIndex = 0;
         this.label8.Text = "Agent, crafted";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ingredientCraftedPanel
         // 
         this.ingredientCraftedPanel.BackColor = System.Drawing.Color.Maroon;
         this.ingredientCraftedPanel.Controls.Add(this.label9);
         this.ingredientCraftedPanel.Location = new System.Drawing.Point(6, 108);
         this.ingredientCraftedPanel.Name = "ingredientCraftedPanel";
         this.ingredientCraftedPanel.Size = new System.Drawing.Size(180, 20);
         this.ingredientCraftedPanel.TabIndex = 7;
         // 
         // label9
         // 
         this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label9.Location = new System.Drawing.Point(0, 0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(180, 20);
         this.label9.TabIndex = 0;
         this.label9.Text = "Ingredient, crafted";
         this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // agentComponentPanel
         // 
         this.agentComponentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentComponentPanel.BackColor = System.Drawing.Color.Maroon;
         this.agentComponentPanel.Controls.Add(this.label10);
         this.agentComponentPanel.Location = new System.Drawing.Point(191, 82);
         this.agentComponentPanel.Name = "agentComponentPanel";
         this.agentComponentPanel.Size = new System.Drawing.Size(180, 20);
         this.agentComponentPanel.TabIndex = 5;
         // 
         // label10
         // 
         this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label10.Location = new System.Drawing.Point(0, 0);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(180, 20);
         this.label10.TabIndex = 0;
         this.label10.Text = "Agent, component";
         this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
         this.legendPanel.ResumeLayout(false);
         this.legendPanel.PerformLayout();
         this.recipeSinglePanel.ResumeLayout(false);
         this.recipeMultiplePnel.ResumeLayout(false);
         this.ingredientGatheredPanel.ResumeLayout(false);
         this.agentGatheredPanel.ResumeLayout(false);
         this.agentCraftedPanel.ResumeLayout(false);
         this.ingredientCraftedPanel.ResumeLayout(false);
         this.agentComponentPanel.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView theTreeView;
      private System.Windows.Forms.SplitContainer manifestSplitContainer;
      private System.Windows.Forms.ListView theListView;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel legendPanel;
      private System.Windows.Forms.Button legendToggleButton;
      private System.Windows.Forms.Panel recipeSinglePanel;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Panel agentGatheredPanel;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Panel ingredientGatheredPanel;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Panel recipeMultiplePnel;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel agentCraftedPanel;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Panel ingredientCraftedPanel;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Panel agentComponentPanel;
      private System.Windows.Forms.Label label10;
   }
}
