using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class MainForm : Form
	{
		private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

		public MainForm()
		{
			InitializeComponent();

			DateTextBox.Text = DateTime.Now.ToString(DateTextBox.FormatProvider);
		}

		private void CopyButtonClick(object sender, EventArgs e)
		{
			var dateTime = DateTime.Parse(DateTextBox.Text, DateTextBox.Culture, DateTimeStyles.AssumeLocal);

			var timeSpan = dateTime.ToUniversalTime() - Epoch;

			var dataObject = new DataObject();

			var messagePlain = string.Format(
				"[{0:hh:mm:ss}] {1}: {2}", 
				dateTime, 
				AuthorFullNameTextBox.Text, 
				MessageTextBox.Text);
			var messageXml = string.Format(
				"<quote author=\"{0}\" timestamp=\"{1}\">{2}</quote>", 
				AuthorTextBox.Text, 
				timeSpan.TotalSeconds, 
				MessageTextBox.Text);

			dataObject.SetData("System.String", messagePlain);
			dataObject.SetData("UnicodeText", messagePlain);
			dataObject.SetData("Text", messagePlain);
			dataObject.SetData("SkypeMessageFragment", new MemoryStream(Encoding.UTF8.GetBytes(messageXml)));
			dataObject.SetData("Locale", new MemoryStream(BitConverter.GetBytes(CultureInfo.CurrentCulture.LCID)));
			dataObject.SetData("OEMText", messagePlain);

			Clipboard.SetDataObject(dataObject, true);
		}
	}
}