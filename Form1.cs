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

namespace janmojannna
{
    public partial class Form1 : Form
    {
        private int remaining_all;
        private int type_all;
        private int accumulated;
        private int timer_cnt;
        private int timer_cnt_max;

        private const int speed         = 16;  // 10msec間にスライドするドット数
        private const int each_max      =  5;  // 各画像の最大数
        private const int deck_max      = 50;  // 使用する山札の割合(%)
        private const string images_dir = @"Images\";

        private Deck[] deck;

        readonly Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(512, 512);
            Set_position();

            // 初期値の設定
            remaining_all = 0;
            type_all      = 0;
            accumulated   = 0;
            timer_cnt     = 0;

            // 画像読み込み
            Load_images();
        }

        private void Set_position()
        {
            int client_w = this.ClientSize.Width;
            int client_h = this.ClientSize.Height;

            button_start.Left       = client_w - button_start.Width - 16;
            button_turn.Location    = new Point(client_w / 2, client_h - button_turn.Height - 16);
            label_hint.Location     = new Point(button_turn.Left + button_turn.Width + 16, button_turn.Top + button_turn.Height - label_hint.Height);
            pictureBox_main.Size    = new Size(client_w - 64, client_h - 128);
            pictureBox_sub.Size     = new Size(client_w - 64, client_h - 128);
            label_accumulated.Top   = button_turn.Top;
            button_get.Top          = button_turn.Top;

            timer_cnt_max = (pictureBox_sub.Width + 32) / speed;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Set_position();
        }

        private void Button_turn_Click(object sender, EventArgs e)
        {
            Change_image();
        }

        private void Load_images()
        {
            List<string> paths = new List<string>();
            foreach(string exp in new string[] { "*.jpg", "*.png", "*.gif" })
            {
                paths.AddRange(Directory.GetFiles(images_dir, exp));
            }

            type_all = paths.Count;
            remaining_all = type_all * each_max;

            deck = new Deck[type_all];

            for(int i=0; i<type_all; ++i)
            {
                deck[i] = new Deck(each_max, paths[i]);
            }

            Reduce_deck();

            Set_labels();
        }

        private void Change_image()
        {
            int deck_idx;

            --remaining_all;
            if(remaining_all < 0)
            {
                // End
                remaining_all = 0;
                return;
            }
            else
            {
                ++accumulated;
                Set_labels();

                // Animation
                if(timer_anime.Enabled)
                {
                    timer_cnt = 0;
                    pictureBox_sub.Left = 32;
                    pictureBox_sub.Image = pictureBox_main.Image;
                }
                else
                {
                    timer_anime.Enabled = true;
                }
            }

            while (true)
            {
                deck_idx = r.Next(type_all);
                if(deck[deck_idx].Remaining != 0)
                {
                    --deck[deck_idx].Remaining;
                    break;
                }
            }

            pictureBox_main.Image = deck[deck_idx].Image;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Change_image();
            }
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            button_turn.Focus();
            accumulated = 0;
            timer_cnt = 0;
            remaining_all = type_all * each_max;
            for(int i=0; i<type_all; ++i)
            {
                deck[i].Remaining = each_max;
            }

            Reduce_deck();

            pictureBox_main.Image = null;
            pictureBox_sub.Image = null;
            Set_labels();
        }

        private void Set_labels()
        {
            label_remaining.Text = "のこり: " + remaining_all + " まい";
            label_accumulated.Text = accumulated + " まい";
        }

        private void Button_get_Click(object sender, EventArgs e)
        {
            button_turn.Focus();
            accumulated = 0;
            Set_labels();
        }

        private void Timer_anime_Tick(object sender, EventArgs e)
        {
            ++timer_cnt;
            if(timer_cnt < timer_cnt_max)
            {
                pictureBox_sub.Left += speed;
            }
            else
            {
                timer_cnt = 0;
                pictureBox_sub.Left = 32;
                pictureBox_sub.Image = pictureBox_main.Image;

                timer_anime.Enabled = false;
            }
        }

        private void Reduce_deck()
        {
            int deck_idx;
            for(int _i=remaining_all * deck_max / 100, _j=remaining_all; _i < _j; ++_i)
            {
                --remaining_all;
                while (true)
                {
                    deck_idx = r.Next(type_all);
                    if (deck[deck_idx].Remaining != 0)
                    {
                        --deck[deck_idx].Remaining;
                        break;
                    }
                }
            }
        }
    }
    internal class Deck
    {
        private int remaining;
        private Bitmap image;

        public Deck(int remaining, string path)
        {
            image = new Bitmap(path);
            this.remaining = remaining;
        }

        public int Remaining
        {
            set { this.remaining = value; }
            get { return this.remaining; }
        }

        public Bitmap Image
        {
            get { return this.image; }
        }
    }

}
