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

namespace MyGames
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListViewLogic _lvl = new ListViewLogic();
        public MainWindow()
        {
            InitializeComponent();

            _lvl.checkFile(this.listView);
        }


        //delete button
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            _lvl.deleteGameFromView(this.listView);
        }

        //add button
        private void add_Click(object sender, RoutedEventArgs e)
        {
            _lvl.addGameToView(this.listView);
        }

        //start game button
        private void play_Click(object sender, RoutedEventArgs e)
        {
            _lvl.startGameFromView(this.listView);
        }

        private void listView_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            _lvl.startGameFromView(this.listView);
        }

        //start game on double click
        private void play_Click(object sender, MouseButtonEventArgs e)
        {
            _lvl.startGameFromView(this.listView);
        }
    }
}

