using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AnadoluAjansı
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

  
 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Left = SystemParameters.VirtualScreenWidth-Width;
            Top = SystemParameters.VirtualScreenHeight-Height-50;
        }
        public ICommand Yenile => new Refresh();

        public class Refresh : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) => true;
            public void Execute(object parameter)
            {
              var xml= (parameter as DataGrid).FindResource("Data") as XmlDataProvider;
                xml.Refresh();
            }
        }
    }
}
