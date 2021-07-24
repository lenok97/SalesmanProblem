using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Salesman
{
    public class SaveToFile
    {
        public static void SaveText(string filename, RichTextBox textBox)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filename, false, Encoding.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ошибка:\n" + ex.Message));
                return;
            };
            
            for (int i = 0; i < textBox.Lines.Count(); i++ )
                writer.WriteLine(textBox.Lines[i]);

            writer.Close();
        }
    }
}
