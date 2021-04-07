using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMCLocker.Views
{
    class CustomViews
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text.Trim();
            return dialogResult;
        }

        public static DialogResult InputBox(string title, string indexTitle, string numberTitle, ref int index, ref int number, ref string type)
        {
            Form form = new Form();
            Label indexLabel = new Label();
            Label numberLabel = new Label();
            Label typeLabel = new Label();
            TextBox indexTextBox = new TextBox();
            TextBox numberTextBox = new TextBox();
            CheckBox typeTextBox = new CheckBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            indexLabel.Text = indexTitle;
            numberLabel.Text = numberTitle;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            numberLabel.SetBounds(9, 20, 372, 13);
            numberTextBox.SetBounds(12, 36, 372, 20);

            indexLabel.SetBounds(9, 60, 372, 13);
            indexTextBox.SetBounds(12, 76, 372, 20);

            typeLabel.SetBounds(9, 100, 372, 13);
            typeTextBox.SetBounds(12, 1066, 372, 20);

            buttonOk.SetBounds(228, 158, 75, 23);
            buttonCancel.SetBounds(309, 158, 75, 23);

            indexLabel.AutoSize = true;
            indexTextBox.Anchor = indexTextBox.Anchor | AnchorStyles.Right;
            numberLabel.AutoSize = true;
            numberTextBox.Anchor = numberTextBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 170);
            form.Controls.AddRange(new Control[] { numberLabel, numberTextBox, indexLabel, indexTextBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, indexLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            string indexStr = indexTextBox.Text.ToString();
            string numberStr = numberTextBox.Text.ToString();
            if (!string.IsNullOrEmpty(indexStr))
            {
                index = int.Parse(indexStr);
            }
            if (!string.IsNullOrEmpty(numberStr))
            {
                number = int.Parse(numberStr);
            }

            return dialogResult;
        }

        public static DialogResult MessageBox(string title, string content, string txtButtonOK, Image icon)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            
            form.Text = title;
            label.Text = content;

            buttonOk.Text = txtButtonOK;
            buttonOk.Image = icon;
            buttonOk.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOk.TextAlign = ContentAlignment.MiddleRight;
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            buttonOk.SetBounds(190, 72, 100, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

    }
}
