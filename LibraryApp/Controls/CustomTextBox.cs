using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Utility;

namespace LibraryApp.Controls
{
    public partial class CustomTextBox : System.Windows.Forms.TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TextBoxMode == TextBoxMode.Number)
            {
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        public TextBoxMode TextBoxMode { get; set; } = TextBoxMode.Text;
        public string FieldPersianName { get; set; }
        public bool IsMandatory { get; set; }
        public string CustomValidationMessage { get; set; }
        public bool IsValid
        {
            get
            {
                if (IsMandatory)
                {
                    switch (TextBoxMode)
                    {
                        case TextBoxMode.NationalCode:
                            {
                                var validationResult = Text.IsNationalCodeValid(out string valMsg);
                                if (validationResult == false)
                                {

                                    CustomValidationMessage = valMsg;
                                }
                                else
                                {
                                    CustomValidationMessage = string.Empty;
                                }
                                return validationResult;
                            }
                        case TextBoxMode.Text:
                            {
                                var validationResult = !string.IsNullOrWhiteSpace(Text);
                                if (validationResult == false)
                                {
                                    CustomValidationMessage = $"لطفا اطلاعات فیلد {FieldPersianName} را پر کنید";
                                }
                                else
                                {
                                    CustomValidationMessage = string.Empty;
                                }
                                return validationResult;
                            }
                        case TextBoxMode.Number:
                            {
                                
                                var validationResult =!string.IsNullOrWhiteSpace(Text) &&  Text.All(r => char.IsNumber(r));
                                if (validationResult == false)
                                {
                                    CustomValidationMessage = $"فیلد {FieldPersianName} باید به صورت عددی باشد";
                                }
                                else
                                {
                                    CustomValidationMessage = string.Empty;
                                }
                                return validationResult;
                            }
                        default:
                            throw new ArgumentException(nameof(TextBoxMode));

                    }
                    // return !string.IsNullOrWhiteSpace(Text);
                }
                return true;
            }
        }
    }

    public enum TextBoxMode
    {
        NationalCode,
        Text,
        Number

    }
}
