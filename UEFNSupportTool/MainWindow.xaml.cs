using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UEFNSupportTool.Util;

namespace UEFNSupportTool;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
///

// TODO: MVVMを意識した書き方に変更する。

public partial class MainWindow : Window
{
    public MainWindow()
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