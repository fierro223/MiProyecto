namespace Orcado
{

    public partial class FrmOrcado : Form
    {
        public FrmOrcado()
        {
            InitializeComponent();
        }
        char[] GuessWord;
        char[] HideWord;
        int intentos = 6;
        string wordFinal;
        List<char> letterUsed = new List<char>();
        private int puntuacion;

        public void getWord()
        {
            string[] arrayWords = { "argentina", "bolivia", "brasil", "chile", "venezuela" };
            int IndexFind = 0;
            Random random = new Random();
            IndexFind = random.Next(arrayWords.Length);
            wordFinal = arrayWords[IndexFind];
            GuessWord = arrayWords[IndexFind].ToCharArray();
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
            lblScore.Text = "Puntuacion" + puntuacion;
        }
        public void resetGame()
        {
            GuessWord = null;
            HideWord = null;
            intentos = 6;
            wordFinal = string.Empty;
            getWord();
            showWord();
            txtSend.Text = string.Empty;
            letterUsed.Clear();
            ltrUsed.Items.Clear();

        }
        public void findLetter(char letterFind)
        {
            bool found = false;

            if (!letterUsed.Contains(letterFind))
            {
                for (int i = 0; i < GuessWord.Length; i++)
                {
                    if (GuessWord[i] == letterFind)
                    {
                        HideWord[i] = letterFind;
                        found = true;
                    }

                }


                letterUsed.Add(letterFind);
                ltrUsed.Items.Add(letterFind);

                if (found == false)
                {
                    intentos--;

                    if (intentos == 0)
                    {
                        if (MessageBox.Show("Lo siento perdiste: La palabra era: " + wordFinal +
                            " ¿Quieres intentar otra ves?", "Perdiste", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            resetGame();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Ya existe esa letras:" + letterFind);
            }

        }
        private bool WinWord()
        {//operador ternario 
         // return !HideWord.Contains('_') ? true : false;
            return !HideWord.Contains('_');
        }
        public FrmOrcado(String Usuario)
        {
            InitializeComponent();
            lblWelcome.Text = "Bienvenido " + Usuario;
            lblScore.Text = "Puntuacion";
            getWord();
            showWord();

        }
        private void FrmOrcado_Load(object sende, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            resetGame();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend.Text.Trim().Length > 0)
            {
                findLetter(char.Parse(txtSend.Text));
                showWord();
                txtSend.Text = String.Empty;

                if (WinWord() == true)
                {
                    if (MessageBox.Show("Felizitaciones has Ganado ",
                        " ¿Quieres intentar otra ves? Ganaste", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        puntuacion++;
                        resetGame();

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
               
            }
        }
        private void txtSend_textChanfed(object sebder, EventArgs e)
        {

        }
    }
}
