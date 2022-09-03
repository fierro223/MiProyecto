namespace Hangman
{
    public partial class FrmHangman : Form
    {

        public FrmHangman()
        {
            InitializeComponent();
        }

        char[] GuessWord;
        char[] HideWord;
        int intentos = 6;
        string wordFinal;
        List<char> lettersUsed = new List<char>();
        public void getWord()
        {
            string[] arraywords = { "argentina", "bolivia", "brasil", "chile", "venezuela", "colombia", "paraguay" };
            int IndexFind = 0;
            Random random = new Random();
            IndexFind = random.Next(arraywords.Length);
            wordFinal = arraywords[IndexFind];
            GuessWord = arraywords[IndexFind].ToCharArray();            
            HideWord = new char[GuessWord.Length];
            for (int i = 0; i < HideWord.Length; i++)
            {
                HideWord[i] = '_';
            }
        }

        public void showWord()
        {
            string word = string.Empty;
            foreach (char letter in HideWord)
            {
                word += letter + " ";
            }
            LblWord.Text = word;
            LblTries.Text = "Intentos: " + intentos;

        }

        public void resetGame()
        {
            GuessWord = null;
            HideWord = null;
            intentos = 6;
            wordFinal = String.Empty;
            getWord();
            showWord();
            TxtSend.Text = String.Empty;
        }

        public void findLetter(char LetterFind)
        {   
            bool found = false;

            if (!lettersUsed.Contains(LetterFind))
            {
                for (int i = 0; i < GuessWord.Length; i++)
                {
                    if (GuessWord[i] == LetterFind)
                    {
                        HideWord[i] = LetterFind;
                        found = true;
                    }

                }
            
                lettersUsed.Add(LetterFind);

                if (found == false)
                {
                    intentos--;
                    if (intentos == 0)
                    {
                        if (MessageBox.Show("¡Lo siento, perdiste! La palabra era: " + wordFinal +
                            " ¿Quieres intentar otra vez?", "Perdiste", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            resetGame();
                        }
                        else
                        {
                            this.Close();
                            break;
                        }
                    }

                }



            }
            else
            {
                MessageBox.Show("Ya usaste esta letra: " + LetterFind);
            }
            
            
        }

        public FrmHangman(string User)
        {
            InitializeComponent();
            LblWelcome.Text = "Bienvenido, " + User;
            LblScore.Text = "Puntuación: ";
            getWord();
            showWord();
        }

        private void FrmHangman_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWord();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            findLetter(char.Parse(TxtSend.Text));
            showWord();
        }

        private void TxtSend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}