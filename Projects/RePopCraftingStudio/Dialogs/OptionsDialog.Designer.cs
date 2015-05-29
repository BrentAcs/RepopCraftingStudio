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
         this.agentComponentButton = new System.Windows.Forms.Button();
         this.agentComponentPanel = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.agentCraftedButton = new System.Windows.Forms.Button();
         this.agentCraftedPanel = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.agentGatheredButton = new System.Windows.Forms.Button();
         this.agentGatheredPanel = new System.Windows.Forms.Panel();
         this.label7 = new System.Windows.Forms.Label();
         this.ingredientCraftedButton = new System.Windows.Forms.Button();
         this.ingredientCraftedPanel = new System.Windows.Forms.Panel();
         this.label4 = new System.Windows.Forms.Label();
         this.ingredientGatheredButton = new System.Windows.Forms.Button();
         this.ingredientGatheredPanel = new System.Windows.Forms.Panel();
         this.label5 = new System.Windows.Forms.Label();
         this.recipeMultipleChoiceButton = new System.Windows.Forms.Button();
         this.recipeMultipleChoicePanel = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.recipeSingleChoiceButton = new System.Windows.Forms.Button();
         this.recipeSingleChoicePanel = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.theColorDialog = new System.Windows.Forms.ColorDialog();
         this.theTabControl.SuspendLayout();
         this.manifestTreeTabPage.SuspendLayout();
         this.agentComponentPanel.SuspendLayout();
         this.agentCraftedPanel.SuspendLayout();
         this.agentGatheredPanel.SuspendLayout();
         this.ingredientCraftedPanel.SuspendLayout();
         this.ingredientGatheredPanel.SuspendLayout();
         this.recipeMultipleChoicePanel.SuspendLayout();
         this.recipeSingleChoicePanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.okButton.Location = new System.Drawing.Point(223, 298);
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
         this.cancelButton.Location = new System.Drawing.Point(304, 298);
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
         this.theTabControl.Size = new System.Drawing.Size(389, 290);
         this.theTabControl.TabIndex = 2;
         // 
         // manifestTreeTabPage
         // 
         this.manifestTreeTabPage.Controls.Add(this.agentComponentButton);
         this.manifestTreeTabPage.Controls.Add(this.agentComponentPanel);
         this.manifestTreeTabPage.Controls.Add(this.agentCraftedButton);
         this.manifestTreeTabPage.Controls.Add(this.agentCraftedPanel);
         this.manifestTreeTabPage.Controls.Add(this.agentGatheredButton);
         this.manifestTreeTabPage.Controls.Add(this.agentGatheredPanel);
         this.manifestTreeTabPage.Controls.Add(this.ingredientCraftedButton);
         this.manifestTreeTabPage.Controls.Add(this.ingredientCraftedPanel);
         this.manifestTreeTabPage.Controls.Add(this.ingredientGatheredButton);
         this.manifestTreeTabPage.Controls.Add(this.ingredientGatheredPanel);
         this.manifestTreeTabPage.Controls.Add(this.recipeMultipleChoiceButton);
         this.manifestTreeTabPage.Controls.Add(this.recipeMultipleChoicePanel);
         this.manifestTreeTabPage.Controls.Add(this.recipeSingleChoiceButton);
         this.manifestTreeTabPage.Controls.Add(this.recipeSingleChoicePanel);
         this.manifestTreeTabPage.Controls.Add(this.label1);
         this.manifestTreeTabPage.Location = new System.Drawing.Point(4, 22);
         this.manifestTreeTabPage.Name = "manifestTreeTabPage";
         this.manifestTreeTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.manifestTreeTabPage.Size = new System.Drawing.Size(381, 264);
         this.manifestTreeTabPage.TabIndex = 0;
         this.manifestTreeTabPage.Text = "Manifest Tree";
         this.manifestTreeTabPage.UseVisualStyleBackColor = true;
         // 
         // agentComponentButton
         // 
         this.agentComponentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentComponentButton.Location = new System.Drawing.Point(298, 222);
         this.agentComponentButton.Name = "agentComponentButton";
         this.agentComponentButton.Size = new System.Drawing.Size(75, 23);
         this.agentComponentButton.TabIndex = 14;
         this.agentComponentButton.Text = "change...";
         this.agentComponentButton.UseVisualStyleBackColor = true;
         this.agentComponentButton.Click += new System.EventHandler(this.agentComponentButton_Click);
         // 
         // agentComponentPanel
         // 
         this.agentComponentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.agentComponentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
         this.agentComponentPanel.Controls.Add(this.label8);
         this.agentComponentPanel.Location = new System.Drawing.Point(18, 222);
         this.agentComponentPanel.Name = "agentComponentPanel";
         this.agentComponentPanel.Size = new System.Drawing.Size(274, 23);
         this.agentComponentPanel.TabIndex = 13;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(3, 5);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(94, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = "Agent, component";
         // 
         // agentCraftedButton
         // 
         this.agentCraftedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentCraftedButton.Location = new System.Drawing.Point(298, 193);
         this.agentCraftedButton.Name = "agentCraftedButton";
         this.agentCraftedButton.Size = new System.Drawing.Size(75, 23);
         this.agentCraftedButton.TabIndex = 12;
         this.agentCraftedButton.Text = "change...";
         this.agentCraftedButton.UseVisualStyleBackColor = true;
         this.agentCraftedButton.Click += new System.EventHandler(this.agentCraftedButton_Click);
         // 
         // agentCraftedPanel
         // 
         this.agentCraftedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.agentCraftedPanel.BackColor = System.Drawing.Color.Yellow;
         this.agentCraftedPanel.Controls.Add(this.label6);
         this.agentCraftedPanel.Location = new System.Drawing.Point(18, 193);
         this.agentCraftedPanel.Name = "agentCraftedPanel";
         this.agentCraftedPanel.Size = new System.Drawing.Size(274, 23);
         this.agentCraftedPanel.TabIndex = 11;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(3, 5);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(74, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Agent, crafted";
         // 
         // agentGatheredButton
         // 
         this.agentGatheredButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.agentGatheredButton.Location = new System.Drawing.Point(298, 164);
         this.agentGatheredButton.Name = "agentGatheredButton";
         this.agentGatheredButton.Size = new System.Drawing.Size(75, 23);
         this.agentGatheredButton.TabIndex = 10;
         this.agentGatheredButton.Text = "change...";
         this.agentGatheredButton.UseVisualStyleBackColor = true;
         this.agentGatheredButton.Click += new System.EventHandler(this.agentGatheredButton_Click);
         // 
         // agentGatheredPanel
         // 
         this.agentGatheredPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.agentGatheredPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.agentGatheredPanel.Controls.Add(this.label7);
         this.agentGatheredPanel.Location = new System.Drawing.Point(18, 164);
         this.agentGatheredPanel.Name = "agentGatheredPanel";
         this.agentGatheredPanel.Size = new System.Drawing.Size(274, 23);
         this.agentGatheredPanel.TabIndex = 9;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(3, 5);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(83, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "Agent, gathered";
         // 
         // ingredientCraftedButton
         // 
         this.ingredientCraftedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ingredientCraftedButton.Location = new System.Drawing.Point(298, 125);
         this.ingredientCraftedButton.Name = "ingredientCraftedButton";
         this.ingredientCraftedButton.Size = new System.Drawing.Size(75, 23);
         this.ingredientCraftedButton.TabIndex = 8;
         this.ingredientCraftedButton.Text = "change...";
         this.ingredientCraftedButton.UseVisualStyleBackColor = true;
         this.ingredientCraftedButton.Click += new System.EventHandler(this.ingredientCraftedButton_Click);
         // 
         // ingredientCraftedPanel
         // 
         this.ingredientCraftedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ingredientCraftedPanel.BackColor = System.Drawing.Color.Lime;
         this.ingredientCraftedPanel.Controls.Add(this.label4);
         this.ingredientCraftedPanel.Location = new System.Drawing.Point(18, 125);
         this.ingredientCraftedPanel.Name = "ingredientCraftedPanel";
         this.ingredientCraftedPanel.Size = new System.Drawing.Size(274, 23);
         this.ingredientCraftedPanel.TabIndex = 7;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 5);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(93, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Ingredient, crafted";
         // 
         // ingredientGatheredButton
         // 
         this.ingredientGatheredButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ingredientGatheredButton.Location = new System.Drawing.Point(298, 96);
         this.ingredientGatheredButton.Name = "ingredientGatheredButton";
         this.ingredientGatheredButton.Size = new System.Drawing.Size(75, 23);
         this.ingredientGatheredButton.TabIndex = 6;
         this.ingredientGatheredButton.Text = "change...";
         this.ingredientGatheredButton.UseVisualStyleBackColor = true;
         this.ingredientGatheredButton.Click += new System.EventHandler(this.ingredientGatheredButton_Click);
         // 
         // ingredientGatheredPanel
         // 
         this.ingredientGatheredPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ingredientGatheredPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.ingredientGatheredPanel.Controls.Add(this.label5);
         this.ingredientGatheredPanel.Location = new System.Drawing.Point(18, 96);
         this.ingredientGatheredPanel.Name = "ingredientGatheredPanel";
         this.ingredientGatheredPanel.Size = new System.Drawing.Size(274, 23);
         this.ingredientGatheredPanel.TabIndex = 5;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(3, 5);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(102, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = "Ingredient, gathered";
         // 
         // recipeMultipleChoiceButton
         // 
         this.recipeMultipleChoiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.recipeMultipleChoiceButton.Location = new System.Drawing.Point(298, 57);
         this.recipeMultipleChoiceButton.Name = "recipeMultipleChoiceButton";
         this.recipeMultipleChoiceButton.Size = new System.Drawing.Size(75, 23);
         this.recipeMultipleChoiceButton.TabIndex = 4;
         this.recipeMultipleChoiceButton.Text = "change...";
         this.recipeMultipleChoiceButton.UseVisualStyleBackColor = true;
         this.recipeMultipleChoiceButton.Click += new System.EventHandler(this.recipeMultipleChoiceButton_Click);
         // 
         // recipeMultipleChoicePanel
         // 
         this.recipeMultipleChoicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.recipeMultipleChoicePanel.BackColor = System.Drawing.Color.Cyan;
         this.recipeMultipleChoicePanel.Controls.Add(this.label3);
         this.recipeMultipleChoicePanel.Location = new System.Drawing.Point(18, 57);
         this.recipeMultipleChoicePanel.Name = "recipeMultipleChoicePanel";
         this.recipeMultipleChoicePanel.Size = new System.Drawing.Size(274, 23);
         this.recipeMultipleChoicePanel.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 5);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(117, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Recipe, multiple choice";
         // 
         // recipeSingleChoiceButton
         // 
         this.recipeSingleChoiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.recipeSingleChoiceButton.Location = new System.Drawing.Point(298, 28);
         this.recipeSingleChoiceButton.Name = "recipeSingleChoiceButton";
         this.recipeSingleChoiceButton.Size = new System.Drawing.Size(75, 23);
         this.recipeSingleChoiceButton.TabIndex = 2;
         this.recipeSingleChoiceButton.Text = "change...";
         this.recipeSingleChoiceButton.UseVisualStyleBackColor = true;
         this.recipeSingleChoiceButton.Click += new System.EventHandler(this.recipeSingleChoiceButton_Click);
         // 
         // recipeSingleChoicePanel
         // 
         this.recipeSingleChoicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.recipeSingleChoicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.recipeSingleChoicePanel.Controls.Add(this.label2);
         this.recipeSingleChoicePanel.Location = new System.Drawing.Point(18, 28);
         this.recipeSingleChoicePanel.Name = "recipeSingleChoicePanel";
         this.recipeSingleChoicePanel.Size = new System.Drawing.Size(274, 23);
         this.recipeSingleChoicePanel.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 5);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(109, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Recipe, single choice";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(36, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Colors";
         // 
         // theColorDialog
         // 
         this.theColorDialog.FullOpen = true;
         // 
         // OptionsDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(391, 333);
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
         this.manifestTreeTabPage.ResumeLayout(false);
         this.manifestTreeTabPage.PerformLayout();
         this.agentComponentPanel.ResumeLayout(false);
         this.agentComponentPanel.PerformLayout();
         this.agentCraftedPanel.ResumeLayout(false);
         this.agentCraftedPanel.PerformLayout();
         this.agentGatheredPanel.ResumeLayout(false);
         this.agentGatheredPanel.PerformLayout();
         this.ingredientCraftedPanel.ResumeLayout(false);
         this.ingredientCraftedPanel.PerformLayout();
         this.ingredientGatheredPanel.ResumeLayout(false);
         this.ingredientGatheredPanel.PerformLayout();
         this.recipeMultipleChoicePanel.ResumeLayout(false);
         this.recipeMultipleChoicePanel.PerformLayout();
         this.recipeSingleChoicePanel.ResumeLayout(false);
         this.recipeSingleChoicePanel.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TabControl theTabControl;
      private System.Windows.Forms.TabPage manifestTreeTabPage;
      private System.Windows.Forms.ColorDialog theColorDialog;
      private System.Windows.Forms.Button recipeSingleChoiceButton;
      private System.Windows.Forms.Panel recipeSingleChoicePanel;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button ingredientCraftedButton;
      private System.Windows.Forms.Panel ingredientCraftedPanel;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button ingredientGatheredButton;
      private System.Windows.Forms.Panel ingredientGatheredPanel;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button recipeMultipleChoiceButton;
      private System.Windows.Forms.Panel recipeMultipleChoicePanel;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button agentComponentButton;
      private System.Windows.Forms.Panel agentComponentPanel;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Button agentCraftedButton;
      private System.Windows.Forms.Panel agentCraftedPanel;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button agentGatheredButton;
      private System.Windows.Forms.Panel agentGatheredPanel;
      private System.Windows.Forms.Label label7;
   }
}