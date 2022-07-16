using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace LetterCounter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        AlphaBet alpha = new AlphaBet();
        int vovel_count;
        int cons_count;
        int symbols_count;

        public MainWindow()
        {
            //LoadAlpha.ExportJson();
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            var text = InputText.Text.ToString();
            Calculate(text);
            VovelsCount.Text = vovel_count.ToString();
            ConsCount.Text = cons_count.ToString();
            SymbolCount.Text = symbols_count.ToString();
        }

        private async Task Calculate(string text)
        {
            await Task.Run(() => VovelsVeiw(text));
            await Task.Run(() => ConsVeiw(text));
            await Task.Run(() => SymbolView(text));
            
        }

         void VovelsVeiw(string text)
        {
            vovel_count = CounterLetters.Count(text, alpha.vovels);
        }
        void ConsVeiw(string text)
        {
            cons_count = CounterLetters.Count(text, alpha.cons);
        }
        void SymbolView(string text)
        {

            symbols_count= CounterLetters.Count(text, alpha.symbols);
        }

        private void Lang_Selected(object sender, RoutedEventArgs e)
        {
            if (RU.IsSelected)
            {
                InputText.Text = "Введите текст на русском языке:";
                alpha = LoadAlpha.Load("RU");
            }
            else
            {
                InputText.Text = "Input English text:";
                alpha = LoadAlpha.Load("EN");

            }

        }
    }



}
