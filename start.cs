using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HangMan
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        int score = 0;
        public int getRandom(int i, int j)
        {
            Random rd = new Random();
            return rd.Next(i, j);
        }
        string mainWord = "";
        string word = "";
        private void start_Load(object sender, EventArgs e)
        {
            string info  = changeWord();
            if(info.Length <=5)
            {
                word = info[0].ToString();
                for(int i=1;i<=info.Length;i++)
                {
                    word += "_";
                }
                word = word.Remove(word.Length-1);
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }else
            if(info.Length >5 && info.Length <9)
            {
                Random rd = new Random();
                int a = rd.Next(0, info.Length);
                int b = rd.Next(0, info.Length);
                while (b == a)
                    b = rd.Next(0, info.Length);
                for(int i=0;i<=info.Length;i++)
                {
                    if (i == a)
                    {
                        word += info[a].ToString();
                    }
                    else
                    if (i == b)
                    {
                        word += info[b].ToString();
                    }
                    else
                        word += "_";
                }
                if (word.Length > info.Length)
                {
                    word = word.Remove(word.Length - 1);
                }
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }else
            if(info.Length >=9 && info.Length <13)
            {
                Random rd = new Random();
                int a = rd.Next(0, info.Length);
                int b = rd.Next(0, info.Length);
                int c = rd.Next(0, info.Length);
                while (b == a || b == c || a == c)
                {
                    b = rd.Next(0, info.Length);
                    c = rd.Next(0, info.Length);
                }
                for (int i = 0; i <= info.Length; i++)
                {
                    if (i == a)
                    {
                        word += info[a].ToString();
                    }
                    else
                    if (i == b)
                    {
                        word += info[b].ToString();
                    }
                    else
                    if(i== c)
                    {
                        word += info[c].ToString();
                    }
                    else
                        word += "_";
                }
                if (word.Length > info.Length)
                {
                    word = word.Remove(word.Length - 1);
                }
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }else
            if(info.Length >=13 && info.Length <17)
            {
                Random rd = new Random();
                int a = rd.Next(0, info.Length);
                int b = rd.Next(0, info.Length);
                int c = rd.Next(0, info.Length);
                int d = rd.Next(0, info.Length);
                while (a == b || a == c || a == d || b == c || b == d || c ==d )
                {
                    b = rd.Next(0, info.Length);
                    c = rd.Next(0, info.Length);
                    d = rd.Next(0, info.Length);
                }
                for (int i = 0; i <= info.Length; i++)
                {
                    if (i == a)
                    {
                        word += info[a].ToString();
                    }
                    else
                    if (i == b)
                    {
                        word += info[b].ToString();
                    }
                    else
                    if (i == c)
                    {
                        word += info[c].ToString();
                    }
                    else
                    if(i == d)
                    {
                        word += info[d].ToString();
                    }
                    else
                        word += "_";
                }
                if (word.Length > info.Length)
                {
                    word = word.Remove(word.Length - 1);
                }
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }else
            if(info.Length >=17 && info.Length < 21)
            {
                Random rd = new Random();
                int a = rd.Next(0, info.Length);
                int b = rd.Next(0, info.Length);
                int c = rd.Next(0, info.Length);
                int d = rd.Next(0, info.Length);
                int ef = rd.Next(0, info.Length);
                while (a == b || a == c || a == d || a==ef || b==c || b==d ||b==ef||c==d||c==ef||d==ef)
                {
                    b = rd.Next(0, info.Length);
                    c = rd.Next(0, info.Length);
                    d = rd.Next(0, info.Length);
                    ef = rd.Next(0, info.Length);
                }
                for (int i = 0; i <= info.Length; i++)
                {
                    if (i == a)
                    {
                        word += info[a].ToString();
                    }
                    else
                    if (i == b)
                    {
                        word += info[b].ToString();
                    }
                    else
                    if (i == c)
                    {
                        word += info[c].ToString();
                    }
                    else
                    if (i == d)
                    {
                        word += info[d].ToString();
                    }
                    else
                    if(i == ef)
                    {
                        word += info[ef].ToString();
                    }
                    else
                        word += "_";
                }
                if (word.Length > info.Length)
                {
                    word = word.Remove(word.Length - 1);
                }
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }
            else
            if (info.Length >=21)
            {
                Random rd = new Random();
                int a = rd.Next(0, info.Length);
                int b = rd.Next(0, info.Length);
                int c = rd.Next(0, info.Length);
                int d = rd.Next(0, info.Length);
                int ef = rd.Next(0, info.Length);
                int f = rd.Next(0, info.Length);

                while (a == b || a == c || a == d || a == ef || a== f|| b == c || b == d || b == ef ||b==f||  c == d || c == ef || c==f|| d == ef||d==f||ef==f)
                {
                    b = rd.Next(0, info.Length);
                    c = rd.Next(0, info.Length);
                    d = rd.Next(0, info.Length);
                    ef = rd.Next(0, info.Length);
                    f = rd.Next(0, info.Length);
                }
                for (int i = 0; i <= info.Length; i++)
                {
                    if (i == a)
                    {
                        word += info[a].ToString();
                    }
                    else
                    if (i == b)
                    {
                        word += info[b].ToString();
                    }
                    else
                    if (i == c)
                    {
                        word += info[c].ToString();
                    }
                    else
                    if (i == d)
                    {
                        word += info[d].ToString();
                    }
                    else
                    if (i == ef)
                    {
                        word += info[ef].ToString();
                    }
                    else
                        word += "_";
                }
                if (word.Length > info.Length)
                {
                    word = word.Remove(word.Length - 1);
                }
                string h = "";
                for (int k = 0; k < word.Length; k++)
                {
                    h += word[k] + " ";
                }
                hiddenword.Text = h.ToString();
                mainWord = info;
            }
            
        }   // loads the word
        int p = 0;
        private void button2_Click(object sender, EventArgs e)   // sent button
        {
            string makingWord = "";
            for(int i=0;i<mainWord.Length;i++)
            {
                makingWord += mainWord[i] + " ";
            }
            if (makingWord == hiddenword.Text)
                MessageBox.Show("The word is already filled!");
            else
            if (Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]$"))
            {

                //tester
                string[] tableTest = label5.Text.Split(' ');
                int ok1 = 0;
                for(int i=0;i<tableTest.Length;i++)
                {
                    if (tableTest[i] == textBox1.Text)
                    {
                        
                        ok1 = 1;
                    }
                }
                if (ok1 == 0)
                {


                    //
                    string x = textBox1.Text;
                    int ok = 0;

                    for (int i = 0; i < mainWord.Length; i++)
                    {
                        if (x.ToUpper() == mainWord[i].ToString().ToUpper() && word[i] == '_')
                        {
                            StringBuilder strBuilder = new StringBuilder(word);
                            strBuilder[i] = x[0];
                            word = strBuilder.ToString();
                            ok = 1;
                            string h = "";
                            for (int k = 0; k < word.Length; k++)
                            {
                                h += word[k] + " ";
                            }
                            hiddenword.Text = h.ToString();
                            score += 10;
                            MyScore.Text = score.ToString();
                        }
                    }
                    if (mainWord == word)
                    {
                        int tester = 0;
                        StreamReader reader = new StreamReader("HighScores.txt");
                        string info = "";
                        int i = 0;

                        while (i < 5 && (info = reader.ReadLine()) != null)
                        {
                            string[] table = info.Split('|');
                            if (score > Convert.ToInt32(table[1]))
                            {
                                tester = 1;
                            }
                            i++;
                        }
                        reader.Close();

                        if (tester == 1)
                        {
                            MessageBox.Show("Felicitari, ai intrat  in top 5");
                        }
                        else
                            MessageBox.Show("You dont reach the top 5, try again!");
                        ok = 1;
                        panel1.BackgroundImage = new Bitmap(@"C:\Users\Ovi\Desktop\CS6-Makeups\HangMan\-1.jpg");
                    }
                    if (ok == 0)
                    {
                        panel1.BackgroundImage = new Bitmap(@"C:\Users\Ovi\Desktop\CS6-Makeups\HangMan\" + p + ".jpg");
                        if (p == 15)
                            p = 0;
                        else
                            p++;
                        score = score - 10;
                        if (score < 0)
                            score = 0;
                        MyScore.Text = score.ToString();
                    }

                    label5.Text += textBox1.Text + " ";
                    textBox1.Text = "";
                }
                else
                    MessageBox.Show("Letter already introduced!");
            }
            else
                MessageBox.Show("It should be only one character introduced!");
            
        }
        int hintTimes = 0;
        private void button4_Click(object sender, EventArgs e)  // hint button
        {
            string hiddenWord = hiddenword.Text;
            Random rd = new Random();
            int x = 0;
            int ok = 0;
            x = rd.Next(0, hiddenWord.Length);
            string wholeWord = "";
            for(int i=0;i<mainWord.Length;i++)
            {
                wholeWord += mainWord[i] + " ";
            }
            if (hiddenword.Text == wholeWord)
                MessageBox.Show("The word is completed! No need for hint");
            else
            {
                while (ok == 0)
                {
                    while (hiddenWord[x] != '_')
                        x = rd.Next(0, wholeWord.Length);
                    if (hiddenWord[x] == '_')
                    {
                        if (hintTimes < 3)
                        {
                            StringBuilder strBuilder = new StringBuilder(hiddenWord);
                            strBuilder[x] = wholeWord[x];
                            hiddenword.Text = strBuilder.ToString();
                            ok = 1;
                            hintTimes++;
                        }
                        else
                        {
                            MessageBox.Show("You dont have any hint!");
                            ok = 1;
                        }

                    }
                }
            }
            if (hiddenword.Text == wholeWord)
            {
                MessageBox.Show("Finishh");
                panel1.BackgroundImage = new Bitmap(@"C:\Users\Ovi\Desktop\CS6-Makeups\HangMan\-1.jpg");
            }

        }
        public string changeWord()
        {
            StreamReader rd = new StreamReader("WordList.txt");
            string info = "";
            List<string> words =new List<string>();
            while ((info=rd.ReadLine())!=null)
            {
                words.Add(info);
            }
            rd.Close();
            Random rand = new Random();
            int r = rand.Next(0, words.Count());
            return words[r];
        }
        private void button3_Click(object sender, EventArgs e)  // surrender button
        {
            panel1.BackgroundImage = new Bitmap(@"C:\Users\Ovi\Desktop\CS6-Makeups\HangMan\14.jpg");
            string h = "";
            for (int i=0;i<mainWord.Length;i++)
            {
                h += mainWord[i] + " ";
            }
            hiddenword.Text = h;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
