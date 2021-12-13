using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace 手機
{
    public partial class sirisystem : Form
    {
        Form1 f1;
        public sirisystem(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        SpeechSynthesizer synth = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();
        SpeechRecognitionEngine srecognize = new SpeechRecognitionEngine();
        string temp = "";
        private void sirisystem_Load(object sender, EventArgs e)
        {
            user1.SizeMode = PictureBoxSizeMode.Zoom;
            siri1.SizeMode = PictureBoxSizeMode.Zoom;
            pbuilder.ClearContent();
            pbuilder.AppendText(textBox1.Text);
            synth.Speak(pbuilder);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
        int which = 0;
        private void sregonize_speechrecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "close")
            {
                textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                textBox2.Text = textBox2.Text + "關閉" + "\r\n";
                srecognize.RecognizeAsyncStop();
                button2.Enabled = true;
                button4.Enabled = false;
            }
            else if (e.Result.Text == "你好" || e.Result.Text == "hello")
            {
                textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                textBox2.Text = textBox2.Text + "哈囉" + "\r\n";
                temp = "哈囉";
                pbuilder.ClearContent();
                pbuilder.AppendText(temp);
                synth.Speak(pbuilder);
            }
            else if (e.Result.Text == "facebook")
            {
                textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                temp = "查詢facebook";
                textBox2.Text = textBox2.Text + "好" + "\r\n";
                pbuilder.ClearContent();
                pbuilder.AppendText(temp);
                synth.Speak(pbuilder);
                System.Diagnostics.Process.Start("https://www.facebook.com/");
            }
            else if (e.Result.Text == "我考試考好爛" || e.Result.Text == "我覺得人生好難")
            {
                Random random = new Random();
                which = random.Next(0, 2);
                if (which == 0)
                {
                    textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                    temp = "別難過大學可以多讀幾年";
                    textBox2.Text = textBox2.Text + "別難過  大學可以多讀幾年" + "\r\n";
                    pbuilder.ClearContent();
                    pbuilder.AppendText(temp);
                    synth.Speak(pbuilder);
                }
                if (which == 1)
                {
                    textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                    temp = "期末加油加油可以的";
                    textBox2.Text = textBox2.Text + "期末加油加油可以的" + "\r\n";
                    pbuilder.ClearContent();
                    pbuilder.AppendText(temp);
                    synth.Speak(pbuilder);
                }

            }
            else if (e.Result.Text == "你今天過得如何")
            {
                textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                temp = "我很好謝謝";
                textBox2.Text = textBox2.Text + "我很好 謝謝" + "\r\n";
                pbuilder.ClearContent();
                pbuilder.AppendText(temp);
                synth.Speak(pbuilder);

            }
            else if (e.Result.Text == "google")
            {
                textBox1.Text = textBox1.Text + e.Result.Text.ToString() + "\r\n";
                temp = "查詢google";
                textBox2.Text = textBox2.Text + "好" + "\r\n";
                pbuilder.ClearContent();
                pbuilder.AppendText(temp);
                synth.Speak(pbuilder);
                System.Diagnostics.Process.Start("https://www.google.com/");
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void sirisystem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            srecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button5.Enabled = true;
            Choices slist = new Choices();
            slist.Add(new string[] { "close", "facebook", "你好", "hello", "你今天過得如何", "google", "我考試考好爛" });
            Grammar gr = new Grammar(new GrammarBuilder(slist));
            try
            {
                srecognize.RequestRecognizerUpdate();
                srecognize.LoadGrammar(gr);
                srecognize.SpeechRecognized += sregonize_speechrecognized;
                srecognize.SetInputToDefaultAudioDevice();
                srecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pbuilder.ClearContent();
            pbuilder.AppendText(textBox1.Text);
            synth.Speak(pbuilder);
        }

        private void sirisystem_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            srecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button5.Enabled = false;
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗e.Cancel = true; // 取消關閉作業
        }
    }
}
