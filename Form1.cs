namespace Wordle_1._0
{


    

    public partial class Form1 : Form


    {




        public Form1()
        {
            InitializeComponent();

        }






        public void Form1_Load(object sender, EventArgs e)
        {

            //loads form up


        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            //Generates random word
            if (W2L1.Text == "") {

                Random random = new Random();
                int num = random.Next(0, 5757);
                string[] words = File.ReadAllLines("Words.txt");
                lowerCaseRandomWord = words[num];

            }
            
            
            //Breaks word into 5 letters
            String randomWord = lowerCaseRandomWord.ToUpper();   
            String letter1 = randomWord.Substring(0, 1);
            String letter2 = randomWord.Substring(1, 1);
            String letter3 = randomWord.Substring(2, 1);
            String letter4 = randomWord.Substring(3, 1);
            String letter5 = randomWord.Substring(4, 1);

            

            //try 1
            if (W1L1.Text == letter1) W1L1.BackColor = Color.Green;
            else if (W1L1.Text == letter2 || W1L1.Text == letter3 || W1L1.Text == letter4 || W1L1.Text == letter5) W1L1.BackColor = Color.Yellow;


            if (W1L2.Text == letter2) W1L2.BackColor = Color.Green;
            else if (W1L2.Text == letter1 || W1L2.Text == letter3 || W1L2.Text == letter4 || W1L2.Text == letter5) W1L2.BackColor = Color.Yellow;


            if (W1L3.Text == letter3) W1L3.BackColor = Color.Green;
            else if (W1L3.Text == letter2 || W1L3.Text == letter1 || W1L3.Text == letter4 || W1L3.Text == letter5) W1L3.BackColor = Color.Yellow;


            if (W1L4.Text == letter4) W1L4.BackColor = Color.Green;
            else if (W1L4.Text == letter2 || W1L4.Text == letter3 || W1L4.Text == letter1 || W1L4.Text == letter5) W1L4.BackColor = Color.Yellow;


            if (W1L5.Text == letter5) W1L5.BackColor = Color.Green;
            else if (W1L5.Text == letter2 || W1L5.Text == letter3 || W1L5.Text == letter4 || W1L5.Text == letter1) W1L5.BackColor = Color.Yellow;



            //try 2
            if (W2L1.Text == letter1) W2L1.BackColor = Color.Green;
            else if (W2L1.Text == letter2 || W2L1.Text == letter3 || W2L1.Text == letter4 || W2L1.Text == letter5) W2L1.BackColor = Color.Yellow;


            if (W2L2.Text == letter2) W2L2.BackColor = Color.Green;
            else if (W2L2.Text == letter1 || W2L2.Text == letter3 || W2L2.Text == letter4 || W2L2.Text == letter5) W2L2.BackColor = Color.Yellow;


            if (W2L3.Text == letter3) W2L3.BackColor = Color.Green;
            else if (W2L3.Text == letter2 || W2L3.Text == letter1 || W2L3.Text == letter4 || W2L3.Text == letter5) W2L3.BackColor = Color.Yellow;


            if (W2L4.Text == letter4) W2L4.BackColor = Color.Green;
            else if (W2L4.Text == letter2 || W2L4.Text == letter3 || W2L4.Text == letter1 || W2L4.Text == letter5) W2L4.BackColor = Color.Yellow;


            if (W2L5.Text == letter5) W2L5.BackColor = Color.Green;


            //TRY 3
            if (W3L1.Text == letter1) W3L1.BackColor = Color.Green;
            else if (W3L1.Text == letter2 || W3L1.Text == letter3 || W3L1.Text == letter4 || W3L1.Text == letter5) W3L1.BackColor = Color.Yellow;

            if (W3L2.Text == letter2) W3L2.BackColor = Color.Green;
            else if (W3L2.Text == letter1 || W3L2.Text == letter3 || W3L2.Text == letter4 || W3L2.Text == letter5) W3L2.BackColor = Color.Yellow;

            if (W3L3.Text == letter3) W3L3.BackColor = Color.Green;
            else if (W3L3.Text == letter2 || W3L3.Text == letter1 || W3L3.Text == letter4 || W3L3.Text == letter5) W3L3.BackColor = Color.Yellow;

            if (W3L4.Text == letter4) W3L4.BackColor = Color.Green;
            else if (W3L4.Text == letter2 || W3L4.Text == letter3 || W3L4.Text == letter1 || W3L4.Text == letter5) W3L4.BackColor = Color.Yellow;

            if (W3L5.Text == letter5) W3L5.BackColor = Color.Green;
            else if (W3L5.Text == letter2 || W3L5.Text == letter3 || W3L5.Text == letter4 || W3L5.Text == letter1) W3L5.BackColor = Color.Yellow;

            //TRY 4
            if (W4L1.Text == letter1) W4L1.BackColor = Color.Green;
            else if (W4L1.Text == letter2 || W4L1.Text == letter3 || W4L1.Text == letter4 || W4L1.Text == letter5) W4L1.BackColor = Color.Yellow;

            if (W4L2.Text == letter2) W4L2.BackColor = Color.Green;
            else if (W4L2.Text == letter1 || W4L2.Text == letter3 || W4L2.Text == letter4 || W4L2.Text == letter5) W4L2.BackColor = Color.Yellow;

            if (W4L3.Text == letter3) W4L3.BackColor = Color.Green;
            else if (W4L3.Text == letter2 || W4L3.Text == letter1 || W4L3.Text == letter4 || W4L3.Text == letter5) W4L3.BackColor = Color.Yellow;

            if (W4L4.Text == letter4) W4L4.BackColor = Color.Green;
            else if (W4L4.Text == letter2 || W4L4.Text == letter3 || W4L4.Text == letter1 || W4L4.Text == letter5) W4L4.BackColor = Color.Yellow;

            if (W4L5.Text == letter5) W4L5.BackColor = Color.Green;
            else if (W4L5.Text == letter2 || W4L5.Text == letter3 || W4L5.Text == letter4 || W4L5.Text == letter1) W4L5.BackColor = Color.Yellow;


            //TRY 5
            if (W5L1.Text == letter1) W5L1.BackColor = Color.Green;
            else if (W5L1.Text == letter2 || W5L1.Text == letter3 || W5L1.Text == letter4 || W5L1.Text == letter5) W5L1.BackColor = Color.Yellow;

            if (W5L2.Text == letter2) W5L2.BackColor = Color.Green;
            else if (W5L2.Text == letter1 || W5L2.Text == letter3 || W5L2.Text == letter4 || W5L2.Text == letter5) W5L2.BackColor = Color.Yellow;

            if (W5L3.Text == letter3) W5L3.BackColor = Color.Green;
            else if (W5L3.Text == letter2 || W5L3.Text == letter1 || W5L3.Text == letter4 || W5L3.Text == letter5) W5L3.BackColor = Color.Yellow;

            if (W5L4.Text == letter4) W5L4.BackColor = Color.Green;
            else if (W5L4.Text == letter2 || W5L4.Text == letter3 || W5L4.Text == letter1 || W5L4.Text == letter5) W5L4.BackColor = Color.Yellow;

            if (W5L5.Text == letter5) W5L5.BackColor = Color.Green;
            else if (W5L5.Text == letter2 || W5L5.Text == letter3 || W5L5.Text == letter4 || W5L5.Text == letter1) W5L5.BackColor = Color.Yellow;
            //TRY 6
            if (W6L1.Text == letter1) W6L1.BackColor = Color.Green;
            else if (W6L1.Text == letter2 || W6L1.Text == letter3 || W6L1.Text == letter4 || W6L1.Text == letter5) W6L1.BackColor = Color.Yellow;

            if (W6L2.Text == letter2) W6L2.BackColor = Color.Green;
            else if (W6L2.Text == letter1 || W6L2.Text == letter3 || W6L2.Text == letter4 || W6L2.Text == letter5) W6L2.BackColor = Color.Yellow;

            if (W6L3.Text == letter3) W6L3.BackColor = Color.Green;
            else if (W6L3.Text == letter2 || W6L3.Text == letter1 || W6L3.Text == letter4 || W6L3.Text == letter5) W6L3.BackColor = Color.Yellow;

            if (W6L4.Text == letter4) W6L4.BackColor = Color.Green;
            else if (W6L4.Text == letter2 || W6L4.Text == letter3 || W6L4.Text == letter1 || W6L4.Text == letter5) W6L4.BackColor = Color.Yellow;

            if (W6L5.Text == letter5) W6L5.BackColor = Color.Green;
            else if (W6L5.Text == letter2 || W6L5.Text == letter3 || W6L5.Text == letter4 || W6L5.Text == letter1) W6L5.BackColor = Color.Yellow;






            
            //Win and Loss Prompt
            if (randomWord == (W1L1.Text + W1L2.Text + W1L3.Text + W1L4.Text + W1L5.Text) ||
               randomWord == (W2L1.Text + W2L2.Text + W2L3.Text + W2L4.Text + W2L5.Text) ||
                randomWord == (W3L1.Text + W3L2.Text + W3L3.Text + W3L4.Text + W3L5.Text) ||
                randomWord == (W4L1.Text + W4L2.Text + W4L3.Text + W4L4.Text + W4L5.Text) ||
                randomWord == (W5L1.Text + W5L2.Text + W5L3.Text + W5L4.Text + W5L5.Text) ||
                randomWord == (W6L1.Text + W6L2.Text + W6L3.Text + W6L4.Text + W6L5.Text)
                )
            {
                gameStatus.Text = "W - You WIN!";
            }
            else if (W6L5.Text == "")
            {
                gameStatus.Text = "WORDLE";
            }
            else gameStatus.Text = "L - The word was " + randomWord;



        
    }
        

        //randomWord Global variable
        string lowerCaseRandomWord { 
            get; set; }




        private void gameStatus_Click(object sender, EventArgs e)
        {
            //gamestatuslabel
        }



        //Play Again Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Empties textboxes
            W1L1.Text = "";                   
            W1L2.Text = "";
            W1L3.Text = "";
            W1L4.Text = "";
            W1L5.Text = "";
            W2L1.Text = "";
            W2L2.Text = "";
            W2L3.Text = "";
            W2L4.Text = "";
            W2L5.Text = "";
            W3L1.Text = "";
            W3L2.Text = "";
            W3L3.Text = "";
            W3L4.Text = "";
            W3L5.Text = "";
            W4L1.Text = "";
            W4L2.Text = "";
            W4L3.Text = "";
            W4L4.Text = "";
            W4L5.Text = "";
            W5L1.Text = "";
            W5L2.Text = "";
            W5L3.Text = "";
            W5L4.Text = "";
            W5L5.Text = "";
            W6L1.Text = "";
            W6L2.Text = "";
            W6L3.Text = "";
            W6L4.Text = "";
            W6L5.Text = "";

            //Changes color of boxes back to white
            W1L1.BackColor = Color.White;
            W1L2.BackColor = Color.White;
            W1L3.BackColor = Color.White;
            W1L4.BackColor = Color.White;
            W1L5.BackColor = Color.White;
            W2L1.BackColor = Color.White;
            W2L2.BackColor = Color.White;
            W2L3.BackColor = Color.White;
            W2L4.BackColor = Color.White;
            W2L5.BackColor = Color.White;
            W3L1.BackColor = Color.White;
            W3L2.BackColor = Color.White;
            W3L3.BackColor = Color.White;
            W3L4.BackColor = Color.White;
            W3L5.BackColor = Color.White;
            W4L1.BackColor = Color.White;
            W4L2.BackColor = Color.White;
            W4L3.BackColor = Color.White;
            W4L4.BackColor = Color.White;
            W4L5.BackColor = Color.White;
            W5L1.BackColor = Color.White;
            W5L2.BackColor = Color.White;
            W5L3.BackColor = Color.White;
            W5L4.BackColor = Color.White;
            W5L5.BackColor = Color.White;
            W6L1.BackColor = Color.White;
            W6L2.BackColor = Color.White;
            W6L3.BackColor = Color.White;
            W6L4.BackColor = Color.White;
            W6L5.BackColor = Color.White;

            //erase previous game status
            gameStatus.Text = "WORDLE";

            //Gets new word to play again
            Random random = new Random();
            int num = random.Next(0, 5757);
            string[] words = File.ReadAllLines("Words.txt");
            lowerCaseRandomWord = words[num];

        }





    }



}

   

