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

namespace MorseCode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TB_IN_TextChanged(object sender, TextChangedEventArgs e)
        {
            char let;
            if (TB_IN != null)
            {
                string result = "";
                foreach(var c in TB_IN.Text)
                {
                    let = char.ToUpper(c);
                    if (char.IsWhiteSpace(let))
                    {
                        result += "-...-";
                    }
                    else if (CL_LAN.SelectedIndex == 0 && (let >= 'А' && let <= 'Я' || let == 'Ё'))
                    {
                        Dictionary<char, string> MorseRus = new Dictionary<char, string>
                        {
                            {'А',".-"},
                            {'Б',"-..."},
                            {'В',".--"},
                            {'Г',"--."},
                            {'Д',"-.."},
                            {'Е',"."},
                            {'Ё',"."},
                            {'Ж',"...-"},
                            {'З',"--.."},
                            {'И',".."},
                            {'Й',".---"},
                            {'К',"-.-"},
                            {'Л',".-.."},
                            {'М',"--"},
                            {'Н',"-."},
                            {'О',"---"},
                            {'П',".--."},
                            {'Р',".-."},
                            {'С',"..."},
                            {'Т',"-"},
                            {'У',"..-"},
                            {'Ф',"..-."},
                            {'Х',"...."},
                            {'Ц',"-.-."},
                            {'Ч',"---."},
                            {'Ш',"----"},
                            {'Щ',"--.-"},
                            {'Ъ',"--.--"},
                            {'Ы',"-.--"},
                            {'Ь',"-..-"},
                            {'Э',"..-.."},
                            {'Ю',"..--"},
                            {'Я',".-.-"},
                        };
                        result += MorseRus[let];
                    }
                    else if(CL_LAN.SelectedIndex == 1 && (let >= 'A' && let <= 'Z'))
                    {
                        Dictionary<char, string> MorseENG = new Dictionary<char, string>
                        {
                            {'A',".-"},
                            {'B',"-..."},
                            {'C',"-.-."},
                            {'D',"-.."},
                            {'E',"."},
                            {'F',"..-."},
                            {'G',"--."},
                            {'H',"...."},
                            {'I',".."},
                            {'J',".---"},
                            {'K',"-.-"},
                            {'L',".-.."},
                            {'M',"--"},
                            {'N',"-."},
                            {'O',"---"},
                            {'P',".--."},
                            {'Q',"--.-"},
                            {'R',".-."},
                            {'S',"..."},
                            {'T',"-"},
                            {'U',"..-"},
                            {'V',"...-"},
                            {'W',".--"},
                            {'X',"-..-"},
                            {'Y',"-.--"},
                            {'Z',"--.."}
                        };
                        result += MorseENG[let];
                    }
                    else if (let >= '0' && let <= '9')
                    {
                        Dictionary<char, string> MorseNum = new Dictionary<char, string>
                        {
                            {'0',"-----"},
                            {'1',".----"},
                            {'2',"..---"},
                            {'3',"...--"},
                            {'4',"....-"},
                            {'5',"....."},
                            {'6',"-...."},
                            {'7',"--..."},
                            {'8',"---.."},
                            {'9',"----."},
                        };
                        result += MorseNum[let];
                    }
                    else if (CL_LAN.SelectedIndex == 0 && ((let >= '!' && let <= '/') || (let >= ':' && let <= '@')))
                    {
                        Dictionary<char, string> MorseSymRus = new Dictionary<char, string>
                        {
                            {'.',"......"},
                            {',',".-.-.-"},
                            {':',"---..."},
                            {';',"-.-.-."},
                            {'(',"-.--.-"},
                            {')',"-.--.-"},
                            {'`',".----."},
                            {'"',".-..-."},
                            {'-',"-....-"},
                            {'/',"-..-."},
                            {'_',"..--.-"},
                            {'?',"..--.."},
                            {'!',"--..--"},
                            {'+',".-.-."},
                            {'@',".--.-."},
                        };
                        result += MorseSymRus[let];
                    }
                    else if (CL_LAN.SelectedIndex == 1 && ((let >= '!' && let <= '/') || (let >= ':' && let <= '@')))
                    {
                        Dictionary<char, string> MorseSymEng = new Dictionary<char, string>
                        {
                            {'.',".-.-.-"},
                            {',',"--..--"},
                            {':',"---..."},
                            {';',"-.-.-."},
                            {'(',"-.--."},
                            {')',"-.--.-"},
                            {'`',".----."},
                            {'"',".-..-."},
                            {'-',"-....-"},
                            {'/',"-..-."},
                            {'_',"..--.-"},
                            {'?',"..--.."},
                            {'!',"-.-.--"},
                            {'+',".-.-."},
                            {'@',".--.-."},
                        };
                        result += MorseSymEng[let];
                    }
                    else
                    {
                        if (CL_LAN.SelectedItem == null)
                        {
                            result = "Язык не выбран!";
                        }
                        else
                        {
                            result = "Нельзя одновременно использовать два языка!";
                        }
                    }
                }
                TB_OUT.Text = result;
            }
        }
    }
}
