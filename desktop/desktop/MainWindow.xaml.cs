using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string MaleLitery = "abcdefghijklmnopqrstuvwxyz";
        private string WielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string Cyfry = "0123456789";

        private string ZnakiSpecjalne = "!@#$%^&*()_+-=";

        private string Haslo = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerujHasloButton_Click(object sender, RoutedEventArgs e)
        {
            Haslo = "";
            Random rand = new Random();

            if (CheckBoxMaleIWielkie.IsChecked == false && CheckBoxCyfry.IsChecked == false && CheckBoxSpecjalne.IsChecked == false)
            {
                int length = int.Parse(IloscZnakow.Text);
                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
             
            }


            if (CheckBoxMaleIWielkie.IsChecked == true && CheckBoxCyfry.IsChecked == false && CheckBoxSpecjalne.IsChecked == false)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if(i == 0)
                    {
                        int indexWielkie = rand.Next(WielkieLitery.Length);
                        Haslo += WielkieLitery[indexWielkie].ToString();

                        i++;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }



            if (CheckBoxMaleIWielkie.IsChecked == true && CheckBoxCyfry.IsChecked == true && CheckBoxSpecjalne.IsChecked == false)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if (i == 0)
                    {
                        int indexWielkie = rand.Next(WielkieLitery.Length);
                        int indexCyfry = rand.Next(Cyfry.Length);

                        Haslo += Cyfry[indexCyfry].ToString();
                        Haslo += WielkieLitery[indexWielkie].ToString();

                        i += 2;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }


            if (CheckBoxMaleIWielkie.IsChecked == true && CheckBoxCyfry.IsChecked == true && CheckBoxSpecjalne.IsChecked == true)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if (i == 0)
                    {
                        int indexWielkie = rand.Next(WielkieLitery.Length);
                        int indexCyfry = rand.Next(Cyfry.Length);
                        int indexZnaki = rand.Next(ZnakiSpecjalne.Length);

                        Haslo += Cyfry[indexCyfry].ToString();
                        Haslo += WielkieLitery[indexWielkie].ToString();
                        Haslo += ZnakiSpecjalne[indexZnaki].ToString();

                        i += 3;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }




            if (CheckBoxMaleIWielkie.IsChecked == false && CheckBoxCyfry.IsChecked == true && CheckBoxSpecjalne.IsChecked == false)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if (i == 0)
                    {
                        int indexCyfry = rand.Next(Cyfry.Length);

                        Haslo += Cyfry[indexCyfry].ToString();

                        i += 1;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }




            if (CheckBoxMaleIWielkie.IsChecked == false && CheckBoxCyfry.IsChecked == true && CheckBoxSpecjalne.IsChecked == true)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if (i == 0)
                    {
                        int indexCyfry = rand.Next(Cyfry.Length);
                        int indexZnaki = rand.Next(ZnakiSpecjalne.Length);

                        Haslo += Cyfry[indexCyfry].ToString();
                        Haslo += ZnakiSpecjalne[indexZnaki].ToString();


                        i += 2;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }



            if (CheckBoxMaleIWielkie.IsChecked == false && CheckBoxCyfry.IsChecked == false && CheckBoxSpecjalne.IsChecked == true)
            {
                int length = int.Parse(IloscZnakow.Text);


                for (int i = 0; i < length; i++)
                {
                    int index = rand.Next(MaleLitery.Length);

                    if (i == 0)
                    {
                        int indexZnaki = rand.Next(ZnakiSpecjalne.Length);

                        Haslo += ZnakiSpecjalne[indexZnaki].ToString();


                        i += 1;
                    }

                    Haslo += MaleLitery[index].ToString();
                }

                MessageBox.Show($"{Haslo}");
            }
        }

        private void ZatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            string Dane  = $"Imie: {ImieTextBox.Text}, Nazwisko: {NazwiskoTextBox.Text}, Stanowisko: {StanowiskoComboBox.Text}, Haslo: {Haslo}";
            MessageBox.Show(Dane);
        }
    }
}