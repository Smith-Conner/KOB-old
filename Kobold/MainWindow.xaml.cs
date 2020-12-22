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

namespace Kobold
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int i;
        public string PlayerSubmitTA;

        public MainWindow()
        {
            InitializeComponent();
            BeginOneDotONE();
        }
        private void xSubmit_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                PlayerSubmitTA = xTextAdventureUserImput.Text.ToLower();
                Keys();
            }
        }
        private void xSubmit_Click(object sender, RoutedEventArgs e)
        {
            PlayerSubmitTA = xTextAdventureUserImput.Text.ToLower();
            Keys();
        }
        private void xClear_Click(object sender, RoutedEventArgs e)
        {
            xTextAdventureUserImput.Text = "";
        }


        //The very Begining of the Text Adventure
        public void BeginOneDotONE()
        {
            xTextAdventureOutput.Text = "Why hello there im sure you know this but you are running KOBold. The best Text Adventure game to have ever been made. Or at least it will be the best shortly. For now I would need you to learn how to use me. Im sure at some point there will be a user manual for me, but for now lets start simple. \n\n " +
                "For starters I am very basic in function and will improve as more users write on my flaws. Please ask me to start the dungeon.";
        }
        public void BeginOneDotTwo()
        {
            xTextAdventureOutput.Text = "Great, now all that you need to do is pick the number of events you want in your adventure. Of course this effects how long you will spend playing this game. So please start by saying how many events you want. Using full sentances will of course help.\n\n " +
                "Please know that at this time there is only 1 event so try not to go over that much.";
        }
        public void BeginOneDotThree()
        {
            xTextAdventureOutput.Text = "See isn't this fun. Already picking the stuff you want to do. Do know that it's going to get more free in your choices";
        }




        // TODO Create a dungeon event
        #region //Dungeon Events

        #endregion

        #region //Key Word finder
        public void Keys()
        {
            if ((PlayerSubmitTA.Contains("start") || PlayerSubmitTA.Contains("begin")) && (PlayerSubmitTA.Contains("dungeon") || PlayerSubmitTA.Contains("adventure")))
            {
                //Starts the dungeon
                BeginOneDotTwo();
            }else if ((PlayerSubmitTA.Contains("1")|| PlayerSubmitTA.Contains("one")) && (PlayerSubmitTA.Contains("event") || PlayerSubmitTA.Contains("floor") || PlayerSubmitTA.Contains("encounter")))
            {
                BeginOneDotThree();
            }
        }
        #endregion

    }
}
