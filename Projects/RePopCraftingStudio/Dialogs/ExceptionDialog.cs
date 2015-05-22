using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace RePopCraftingStudio.Dialogs
{
   public partial class ExceptionDialog : Form
   {
      public Exception Exception { get; private set; }

      public ExceptionDialog( Exception exception )
      {
         Exception = exception;
         InitializeComponent();
      }

      private void ExceptionDialog_Load( object sender, EventArgs e )
      {
         Size = Properties.Settings.Default.LastExceptionDialogSize;
         messageTextBox.Text = Exception.Message;
         stackTraceTextBox.Text = Exception.StackTrace;

         showInnerButton.Enabled = ( null != Exception.InnerException );
      }

      private void ExceptionDialog_FormClosed( object sender, FormClosedEventArgs e )
      {
         Properties.Settings.Default.LastExceptionDialogSize = Size;
      }

      private void showInnerButton_Click( object sender, EventArgs e )
      {
         new ExceptionDialog( Exception.InnerException ).ShowDialog( this );
      }
   }
}
