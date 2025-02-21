using Avalonia.Controls;
using SerwerKrazki.ViewModels;

namespace SerwerKrazki.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyReferences.MainWindow = this;
    }
    
}