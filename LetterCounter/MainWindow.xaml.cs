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

namespace LetterCounter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string vovels = "ЁУЕЫАОЭЯИЮёуеыааоэяию";
        const string cons = "ЙЦКНГШЩЗХЪФВПРЛДЖЧСМТЬБйцкнгшщзхъфвпрлджчсмтьб";
        const string symbols = "~`!@#$%^&*()_+-={}[]:;',./<>?";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            VovelsCount.Text = CounterLetters.Count(InputText.Text.ToString(), vovels).ToString();
            ConsCount.Text = CounterLetters.Count(InputText.Text.ToString(), cons).ToString();
            SymbolCount.Text = CounterLetters.Count(InputText.Text.ToString(), symbols).ToString();

        }
    }
}
