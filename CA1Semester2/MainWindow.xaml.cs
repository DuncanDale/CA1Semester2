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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace CA1Semester2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Player> Playerinfo;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox.ItemsSource = new string[] { "Goalkeeper", "Defender", "Midfielder", "Forward" };


            Player e1 = new Player.Goalkeeper()
            {
                DateOfBirth = new DateTime(1991, 6, 30),
                FirstName = "Kepa",
                Surname = "Arrizabalaga"


            };
            var e2 = new Player.Goalkeeper()
            {
                DateOfBirth = new DateTime(1990, 6, 22),
                FirstName = "Willy",
                Surname = "Caballero"


            };
            var e3 = new Player.Defender()
            {
                DateOfBirth = new DateTime(1992, 6, 11),
                FirstName = "Antonio ",
                Surname = "Rudiger"


            };
            var e4 = new Player.Defender()
            {
                DateOfBirth = new DateTime(1988, 1, 2),
                FirstName = "Cesar ",
                Surname = "Azpilicueta"


            };
            var e5 = new Player.Defender()
            {
                DateOfBirth = new DateTime(1986, 4, 12),
                FirstName = "Reece ",
                Surname = "James"


            };
            var e6 = new Player.Defender()
            {
                DateOfBirth = new DateTime(1994, 1, 22),
                FirstName = "Fikayo ",
                Surname = "Tomori"


            };
            var e7 = new Player.Midfielder()
            {
                DateOfBirth = new DateTime(1990, 8, 19),
                FirstName = "Mateo ",
                Surname = "Kovacic"


            };
            var e8 = new Player.Midfielder()
            {
                DateOfBirth = new DateTime(1989, 3, 29),
                FirstName = "Ross ",
                Surname = "Barkley"


            };
            var e9 = new Player.Midfielder()
            {
                DateOfBirth = new DateTime(1991, 1, 12),
                FirstName = "Mason ",
                Surname = "Mount"


            };
            var e10 = new Player.Midfielder()
            {
                DateOfBirth = new DateTime(1990, 4, 4),
                FirstName = "Billy ",
                Surname = "Gilmour"


            };
            var e11 = new Player.Forward()
            {
                DateOfBirth = new DateTime(1997, 5, 3),
                FirstName = "Tammy ",
                Surname = "Abraham"


            };
            var e12 = new Player.Forward()
            {
                DateOfBirth = new DateTime(1987, 6, 30),
                FirstName = "Michy ",
                Surname = "Batshuayi"


            };
            var e13 = new Player.Forward()
            {
                DateOfBirth = new DateTime(1988, 6, 30),
                FirstName = "Olivier ",
                Surname = "Giroud"


            };

            Playerinfo = new ObservableCollection<Player>();
            Playerinfo.Add(e1);
            Playerinfo.Add(e2);
            Playerinfo.Add(e3);
            Playerinfo.Add(e4);
            Playerinfo.Add(e5);
            Playerinfo.Add(e6);
            Playerinfo.Add(e7);
            Playerinfo.Add(e8);
            Playerinfo.Add(e9);
            Playerinfo.Add(e10);
            Playerinfo.Add(e11);
            Playerinfo.Add(e12);
            Playerinfo.Add(e13);


            Player_listBox.ItemsSource = Playerinfo;
        }
        

        private void Player_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // Player  = Player_listBox.SelectedItem as Player;
        }
    }
}
