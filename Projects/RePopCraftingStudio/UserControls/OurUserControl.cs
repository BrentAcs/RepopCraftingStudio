using System.Windows.Forms;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public class OurUserControl : UserControl
   {
      public RepopDb Db { get; set; }

      public virtual void LoadSettings()
      {
      }

      public virtual void SaveSettings()
      {
      }
   }
}