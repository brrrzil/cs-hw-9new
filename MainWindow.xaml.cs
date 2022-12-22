using System.Windows;

namespace HW9new
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static string[] SplitInputedText(string inText)
        {
            return inText.Split( );
        }

        private void SplitText(object sender, RoutedEventArgs e)
        {
            string inTxt = TextToSplit.Text;
            SplittedText.ItemsSource = SplitInputedText(inTxt);
        }

        private void ReverseText(object sender, RoutedEventArgs e)
        {
            ReversedText.Content = null;
            string inTxt = TextToReverse.Text;
            string[] subString = SplitInputedText(inTxt);
            int subStringLength = subString.Length;
            string[] revString = new string[subStringLength];

            for (int i = subStringLength - 1; i >= 0; i--)
            {
                ReversedText.Content += subString[i] + " ";
            }
        }
    }
}