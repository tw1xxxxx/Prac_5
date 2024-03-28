using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            dataBaseP8Entities bd = new dataBaseP8Entities();
            dataGrid1.ItemsSource = bd.Staff.ToList();
            dataGrid2.ItemsSource = bd.Event_Manager.ToList();
            dataGrid3.ItemsSource = bd.Postavki.ToList();
        }

    }
}
