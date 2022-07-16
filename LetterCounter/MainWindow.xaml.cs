using System.Threading.Tasks;
using System.Windows;

namespace LetterCounter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
         AlphaBet alpha = new AlphaBet();

        public MainWindow()
        {
            //LoadAlpha.ExportJson();
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            var text = InputText.Text.ToString();
            Calculate(text);

        }

        private async Task Calculate(string text)
        {
            await Task.Run(() => VovelsVeiw(text));
            await Task.Run(() => ConsVeiw(text));
            await Task.Run(() => SymbolView(text));
        }

        void VovelsVeiw(string text)
        {
            VovelsCount.Text = CounterLetters.Count(text, alpha.vovels).ToString();
        }
        void ConsVeiw(string text)
        {
            ConsCount.Text = CounterLetters.Count(text, alpha.cons).ToString();
        }
        void SymbolView(string text)
        {

            SymbolCount.Text = CounterLetters.Count(text, alpha.symbols).ToString();
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
