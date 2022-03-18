using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Pais> paises = new ObservableCollection<Pais>();
        public MainWindow()
        {
            this.InitializeComponent();
            cargarListView();
        }
        private void cargarListView()
        {
            paises.Add(new Pais { Nombre = "Argentina", CantidadHabitantes = 40000000 });
            paises.Add(new Pais { Nombre = "Chile", CantidadHabitantes = 17000000 });
            paises.Add(new Pais { Nombre = "Bolivia", CantidadHabitantes = 10000000 });
            paises.Add(new Pais { Nombre = "Perú", CantidadHabitantes = 30000000 });
            paises.Add(new Pais { Nombre = "Ecuador", CantidadHabitantes = 16000000 });
            paises.Add(new Pais { Nombre = "Paraguay", CantidadHabitantes = 7000000 });
            paises.Add(new Pais { Nombre = "Uruguay", CantidadHabitantes = 3000000 });
            paises.Add(new Pais { Nombre = "Brasil", CantidadHabitantes = 200000000 });
            paises.Add(new Pais { Nombre = "Venezuela", CantidadHabitantes = 30000000 });
            paises.Add(new Pais { Nombre = "Colombia", CantidadHabitantes = 48000000 });
            paises.Add(new Pais { Nombre = "Surinam", CantidadHabitantes = 500000 });
            paises.Add(new Pais { Nombre = "Guyana", CantidadHabitantes = 800000 });
            paises.Add(new Pais { Nombre = "Guyana Francesa", CantidadHabitantes = 250000 });
            listView1.ItemsSource = paises;
        }
    }
}
