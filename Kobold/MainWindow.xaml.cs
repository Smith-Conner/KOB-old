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

        public void BeginOneDotONE()
        {
            //xTextAdventureOutput.Text = "Hello, I have been made to give you a fun and exiting new experiance when it comes to text adventures. I want to be the perfect and most well made AI that generates dungeons for the player to explore givin their wants and needs. \n\n To begin please state that you would like to begin the text adventure and the number of levels that you would like in it.";

        }
        
        
        public void method1()
        {

        }
        public void method2()
        {

        }


        
        private void xSubmit_Click(object sender, RoutedEventArgs e)
        {
            PlayerSubmitTA = xTextAdventureUserImput.Text;
        }

        private void xNext_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
