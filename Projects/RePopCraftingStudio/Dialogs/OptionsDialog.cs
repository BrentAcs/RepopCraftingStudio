using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RePopCraftingStudio.Dialogs
{
   public partial class OptionsDialog : Form
   {
      public OptionsDialog()
      {
         InitializeComponent();
      }

      private void OptionsDialog_Load( object sender, EventArgs e )
      {
         recipeSingleChoicePanel.BackColor = (Color)Properties.Settings.Default[ @"RecipeSingleBackColor" ];
         recipeMultipleChoicePanel.BackColor = (Color)Properties.Settings.Default[ @"RecipeMultipleBackColor" ];
         ingredientGatheredPanel.BackColor = (Color)Properties.Settings.Default[ @"IngredientGatheredBackColor" ];
         ingredientCraftedPanel.BackColor = (Color)Properties.Settings.Default[ @"IngredientCraftedBackColor" ];
         agentGatheredPanel.BackColor = (Color)Properties.Settings.Default[ @"AgentGatheredBackColor" ];
         agentCraftedPanel.BackColor = (Color)Properties.Settings.Default[ @"AgentCraftedBackColor" ];
         agentComponentPanel.BackColor = (Color)Properties.Settings.Default[ @"AgentComponentBackColor" ];
      }

      private void OptionsDialog_FormClosing( object sender, FormClosingEventArgs e )
      {
         if ( DialogResult.OK != DialogResult )
            return;

         Properties.Settings.Default[ @"RecipeSingleBackColor" ] = recipeSingleChoicePanel.BackColor;
         Properties.Settings.Default[ @"RecipeMultipleBackColor" ] = recipeMultipleChoicePanel.BackColor;
         Properties.Settings.Default[ @"IngredientGatheredBackColor" ] = ingredientGatheredPanel.BackColor;
         Properties.Settings.Default[ @"IngredientCraftedBackColor" ] = ingredientCraftedPanel.BackColor;
         Properties.Settings.Default[ @"AgentGatheredBackColor" ] = agentGatheredPanel.BackColor;
         Properties.Settings.Default[ @"AgentCraftedBackColor" ] = agentCraftedPanel.BackColor;
         Properties.Settings.Default[ @"AgentComponentBackColor" ] = agentComponentPanel.BackColor;
      }

      private void recipeSingleChoiceButton_Click( object sender, EventArgs e )
      {
         SelectColor( recipeSingleChoicePanel, @"RecipeSingleBackColor" );
      }

      private void recipeMultipleChoiceButton_Click( object sender, EventArgs e )
      {
         SelectColor( recipeMultipleChoicePanel, @"RecipeMultipleBackColor" );
      }

      private void ingredientGatheredButton_Click( object sender, EventArgs e )
      {
         SelectColor( ingredientGatheredPanel, @"IngredientGatheredBackColor" );
      }

      private void ingredientCraftedButton_Click( object sender, EventArgs e )
      {
         SelectColor( ingredientCraftedPanel, @"IngredientCraftedBackColor" );
      }

      private void agentGatheredButton_Click( object sender, EventArgs e )
      {
         SelectColor( agentGatheredPanel, @"AgentGatheredBackColor" );
      }

      private void agentCraftedButton_Click( object sender, EventArgs e )
      {
         SelectColor( agentCraftedPanel, @"AgentCraftedBackColor" );
      }

      private void agentComponentButton_Click( object sender, EventArgs e )
      {
         SelectColor( agentComponentPanel, @"AgentComponentBackColor" );
      }

      private void SelectColor( Panel panel, string colorId )
      {
         theColorDialog.Color = panel.BackColor;
         if ( DialogResult.OK != theColorDialog.ShowDialog( this ) )
            return;
         panel.BackColor = theColorDialog.Color;
      }
   }
}
