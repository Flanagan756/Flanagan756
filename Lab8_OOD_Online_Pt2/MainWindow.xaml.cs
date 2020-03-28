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

namespace Lab8_OOD_Online_Pt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComputerGameData db = new ComputerGameData();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Code for window load
            var query = from t in db.ComputerGames
                        select t.Name;



            lbxComputerGame.ItemsSource = query.ToList();
        }

        private void lbxComputerGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string selectedGame = lbxComputerGame.SelectedItem.ToString();
            if (selectedGame != null)
            {


                if (selectedGame == "Sonic the Hedgehog")
                {
                    var query1 = from p in db.Characters
                                 where p.ComputerGameId == 1
                                 select p.CharacterName;

                    lbxCharacter.ItemsSource = query1.ToList();

                }
                if (selectedGame == "Street Fighter")
                {
                    var query1 = from p in db.Characters
                                 where p.ComputerGameId == 2
                                 select p.CharacterName;

                    lbxCharacter.ItemsSource = query1.ToList();

                }
            }
        }

        private void lbxCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            string selectedCharacter = lbxCharacter.SelectedItem.ToString();
            if (selectedCharacter != null)
            {
               if (selectedCharacter == "Sonic")
                {
                    /*For some reason the Linq Query would get null so did a more simple solution*/

                    //var query = from c in db.Characters
                    //            where c.CharacterId == 1
                    //            select c.CharacterImage;

                    //string image = query.ToString();

                    //imgCharacter.Source = new BitmapImage(new Uri(image));

                    imgCharacter.Source = new BitmapImage(new Uri("https://www.pngfind.com/pngs/m/636-6369855_418kib-779x1025-modern-sonic-modern-sonic-the-hedgehog.png"));

                }
                if (selectedCharacter == "Tails")
                {
                    imgCharacter.Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/en/thumb/1/1a/Miles_%22Tails%22_Prower_Sonic_and_All-Stars_Racing_Transformed.png/220px-Miles_%22Tails%22_Prower_Sonic_and_All-Stars_Racing_Transformed.png"));
                }
                if (selectedCharacter == "Ryu")
                {
                    imgCharacter.Source = new BitmapImage(new Uri("https://i.pinimg.com/originals/9e/65/c8/9e65c8f956254aa21d2efba0cbec945d.jpg"));
                }
                if (selectedCharacter == "Ken")
                {
                    imgCharacter.Source = new BitmapImage(new Uri("https://i.pinimg.com/originals/f5/6e/15/f56e15a748ff707e65343a034a98346a.jpg"));
                }
            }
          
        }
    }
}
