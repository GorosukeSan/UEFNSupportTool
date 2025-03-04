using System.Windows;
using System.Windows.Controls;
using UEFNSupportTool.Models.VerseTag;

namespace UEFNSupportTool.Views.VerseTag;

public partial class VerseTag : UserControl
{
    public VerseTag()
    {
        InitializeComponent();
    }
    
    private void Button_Convert(object sender, RoutedEventArgs e)
    {
        string newText = VerseComponent.PutVerseComponent(TextBox.Text);
        TextBox.Text = newText;
    }

    private void ButtonBase_Copy(object sender, RoutedEventArgs e)
    {
        Clipboard.SetData(DataFormats.Text, TextBox.Text);
    }

    private void ButtonBase_Clear(object sender, RoutedEventArgs e)
    {
        TextBox.Text = string.Empty;
    }

    private void ButtonBase_Paste(object sender, RoutedEventArgs e)
    {
        string? text = Clipboard.GetData(DataFormats.Text).ToString();
        if (text != null)
        {
            TextBox.Text = text;
        }
    }
}