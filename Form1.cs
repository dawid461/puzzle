using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace puzzle
{
    public partial class frmPuzzleGame : Form
    {

        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();


        public frmPuzzleGame()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null}); //tworzenie bitmapy dla 9 obrazków w aplikacji
            lblMovesMade.Text += inmoves;       //odliczanie klikniec w obrazki podczas prób dopasowania
            lblTimeElapsed.Text = "00:00:00"; //start zegara po kliknieciu w obrazek
        }


        //--------------------------------------Rozpoczecie gry od nowa i pomieszanie obrazków--------------------------------------------------------------------------------------------------------------------- 
        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle(); //wywołanie funkcji shuffle
        }
        void Shuffle() //funkcja odpowiedzialna za restart gry i ponowne rozmieszczenie obrazkow w losowych miejscach
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 obrazek jest niedostępny, ponieważ jest ostatnim plasterkiem w układance
                Random r = new Random();//generator liczb losowych
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//przechowuj indeks pustego pola obrazu
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)  //funkcja przechwytująca nacisnięcie przycisku shuffle
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")  //warunek zabezpieczający przed przypadkowym restartem gry
            {
                YesOrNo = MessageBox.Show("Czy na pewno chcesz zrestartowac gre?", "Tractor Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            }
            if(YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00") //po wybraniu opcji ,,tak" na powyzsze pytanie następuję przypisanie poczatkowej wartości do pola ,,wykonane ruchy: 0" i zegaru na wartość ,,00:00:00:"
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Wykonane Ruchy : 0";
            }
        }
        //-------------------------------------------WYJŚCIE Z GRY------------------------------------------------------------------------------------------------------------------------------------
        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e) 
        {
            DialogResult YesOrNO = MessageBox.Show("Czy na pewno chcesz wyjść?", "Tractor Puzzle",MessageBoxButtons.YesNo, MessageBoxIcon.Question); //po naciśnieciu przycisku quit pojawia sie okienko z zapytaniem oraz dwiema odpowiedziami
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true; //jesli wybierzesz opcje ,,NIE" nie opuścisz gry
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0); //jesli wybierzesz opcje ,,TAK" opuścisz gre
        }

        private void btnQuit_Click(object sender, EventArgs e)//funkcja stworzona do przycisku quit  z wywołaniem funkcji, która znajduję się powyżej
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);            
        }
        //----------------------------------------------------------------RUCH OBRAZKOW---------------------------------------------------------------------------------------------------------------
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00") //po przesunięci obrazka następuje rozpoczęcie odliczania czasu
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if(inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });//przesuwanie obrazków
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Wykonane Ruchy : " + (++inmoves);//liczenie przesunięć puzzli
                    if(CheckWin())
                    {
                        timer.Stop(); //zatrzymanie liczenie czasu po ułożeniu puzzli
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Gratulacje... \n Udalo ci sie ulozyc puzzle\n czas jaki uplynal:  " + timer.Elapsed.ToString().Remove(8) + "\nLaczna liczba wykonanych ruchow: " + inmoves, "Tractor Puzzle");
                        inmoves = 0;
                        lblMovesMade.Text = "Wykonane Ruchy : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
          
                            
                }
            }
        }


        // -----------------------------------------warunek sprawdzający czy użytkownik ułożył puzzle-----------------------------------------------------------------------------------------------------------------
        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
        //------------------------------------------------Funkcja dotycząca odliczania czas--------------------------------------------------------------------------------------------------------------------------
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")//przycisk ,,wstrzymaj" nie jest dostępny dopóki gracz nie rozpocznie gry
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "2")//jeśli czas gry przekroczy 2 minuty to następuje koniec gry
            {
                timer.Reset();
                lblMovesMade.Text = "Wykonane Ruchy : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Czas się skończył\nSpróbuj ponownie", "Tractor Puzzle");
                Shuffle();
            }
        }

        //--------------------------------------WSTRZYMANIE PROGRAMU I WZNOWIENIE---------------------------------------------------------------------------------------------------------------------------------
        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Wstrzymaj")//po naciśnięciu przycisku ,,wstrzymaj" następuje ukrycie go i pojawienie się przycisku ,,Wznów" oraz czas zatrzymuje się czas
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Wznów";
            }
            else//po naciśnięciu przycisku ,,Wznów" następuje pojawienie się przycisku ,,Wstrzymaj" i wznowienie czasu
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Wstrzymaj";
            }
        }
         



    }//koniec public partial class
}//koniec namespace puzzle
