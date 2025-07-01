using System.Numerics;

namespace NumericTypesSuggester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LabelSuggestedTypeValue.Text = "not enough data";
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsTextBoxValueValid(e.KeyChar, (TextBox)sender))
            {
                e.Handled = true;
            }
        }
        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            RecalculateSuggestedType();
        }

        private static bool IsTextBoxValueValid(char keyChar, TextBox textBox)
        {
            return
                char.IsDigit(keyChar) ||
                char.IsControl(keyChar) ||
                (keyChar == '-' &&
                textBox.SelectionStart == 0 &&
                !textBox.Text.Contains('-'));
        }

        private void CheckBoxIsIntegralOnly_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxMustBePrecise.Visible = !CheckBoxIsIntegralOnly.Checked;
            RecalculateSuggestedType();
        }

        private void CheckBoxMustBePrecise_CheckedChanged(object sender, EventArgs e)
        {
            RecalculateSuggestedType();
        }

        private void RecalculateSuggestedType()
        {
            if (CheckBoxIsIntegralOnly.Checked)
            {
                BigInteger? textBoxMinValue = null;
                BigInteger? textBoxMaxValue = null;
                if (BigInteger.TryParse(TextBoxMinValue.Text, out BigInteger parsedMinValue))
                {
                    textBoxMinValue = parsedMinValue;
                }
                else
                {
                    textBoxMinValue = null;
                }

                if (BigInteger.TryParse(TextBoxMaxValue.Text, out BigInteger parsedMaxValue))
                {
                    textBoxMaxValue = parsedMaxValue;
                }
                else
                {
                    textBoxMaxValue = null;
                }

                if (textBoxMinValue == null ||
                    textBoxMaxValue == null ||
                    textBoxMaxValue < textBoxMinValue)
                {
                    LabelSuggestedTypeValue.Text = "not enough data";
                    if (textBoxMaxValue < textBoxMinValue)
                    {
                        TextBoxMaxValue.BackColor = Color.Red;
                    }
                }
                else
                {
                    TextBoxMaxValue.BackColor = Color.White;
                    if (textBoxMinValue >= 0 && textBoxMaxValue <= byte.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "byte";
                    }
                    else if (textBoxMinValue >= sbyte.MinValue && textBoxMaxValue <= sbyte.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "sbyte";
                    }
                    else if (textBoxMinValue >= 0 && textBoxMaxValue <= ushort.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "ushort";
                    }
                    else if (textBoxMinValue >= short.MinValue && textBoxMaxValue <= short.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "short";
                    }
                    else if (textBoxMinValue >= 0 && textBoxMaxValue <= uint.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "uint";
                    }
                    else if (textBoxMinValue >= int.MinValue && textBoxMaxValue <= int.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "int";
                    }
                    else if (textBoxMinValue >= 0 && textBoxMaxValue <= ulong.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "ulong";
                    }
                    else if (textBoxMinValue >= long.MinValue && textBoxMaxValue <= long.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "long";
                    }
                    else if (textBoxMinValue < long.MinValue || textBoxMaxValue > ulong.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "BigInteger";
                    }
                }
            }
            else if (!CheckBoxMustBePrecise.Checked)
            {
                Double? textBoxMinValue = null;
                Double? textBoxMaxValue = null;
                if (Double.TryParse(TextBoxMinValue.Text, out Double parsedMinValue))
                {
                    textBoxMinValue = parsedMinValue;
                }
                else
                {
                    textBoxMinValue = null;
                }

                if (Double.TryParse(TextBoxMaxValue.Text, out Double parsedMaxValue))
                {
                    textBoxMaxValue = parsedMaxValue;
                }
                else
                {
                    textBoxMaxValue = null;
                }

                if (textBoxMinValue == null ||
                    textBoxMaxValue == null ||
                    textBoxMaxValue < textBoxMinValue)
                {
                    LabelSuggestedTypeValue.Text = "not enough data";
                    if (textBoxMaxValue < textBoxMinValue)
                    {
                        TextBoxMaxValue.BackColor = Color.Red;
                    }
                }
                else
                {
                    TextBoxMaxValue.BackColor = Color.White;
                    if (textBoxMinValue >= float.MinValue && textBoxMinValue <= float.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "float";
                    }
                    else if (textBoxMinValue >= double.MinValue && textBoxMaxValue <= double.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "double";
                    }
                    else
                    {
                        LabelSuggestedTypeValue.Text = "Impossible representation";
                    }
                }
            }
            else
            {
                Decimal? textBoxMinValue = null;
                Decimal? textBoxMaxValue = null;
                if (Decimal.TryParse(TextBoxMinValue.Text, out Decimal parsedMinValue))
                {
                    textBoxMinValue = parsedMinValue;
                }
                else
                {
                    textBoxMinValue = null;
                }

                if (Decimal.TryParse(TextBoxMaxValue.Text, out Decimal parsedMaxValue))
                {
                    textBoxMaxValue = parsedMaxValue;
                }
                else
                {
                    textBoxMaxValue = null;
                }

                if (textBoxMinValue == null ||
                    textBoxMaxValue == null ||
                    textBoxMaxValue < textBoxMinValue)
                {
                    LabelSuggestedTypeValue.Text = "not enough data";
                    if (textBoxMaxValue < textBoxMinValue)
                    {
                        TextBoxMaxValue.BackColor = Color.Red;
                    }
                }
                else
                {
                    TextBoxMaxValue.BackColor = Color.White;
                    if (textBoxMinValue >= decimal.MinValue && textBoxMaxValue <= decimal.MaxValue)
                    {
                        LabelSuggestedTypeValue.Text = "decimal";
                    }
                    else
                    {
                        LabelSuggestedTypeValue.Text = "Impossible representation";
                    }
                }
            }
        }
    }
}
