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

namespace Lab8_OOD_Online
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamData db = new TeamData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Code for window load
            var query = from t in db.Teams
                        select t.TeamName;

            var teams = query.ToList();

            lbxTeams.ItemsSource = teams;         
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedTeam = lbxTeams.SelectedItem.ToString();
            if (selectedTeam != null)
            {
                if (selectedTeam == "Sligo Rovers")
                {
                    var query1 = from p in db.Players
                                 where p.TeamId == 1
                                 select p.Name;

                    lbxPlayers.ItemsSource = query1.ToList();

                }
                if (selectedTeam == "Hampton FC")
                {
                    var query2 = from p in db.Players
                                 where p.TeamId == 2
                                 select p.Name;

                    lbxPlayers.ItemsSource = query2.ToList();

                }
            }
           
        }
    }
}
