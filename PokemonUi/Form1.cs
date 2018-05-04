using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonUi
{
    public partial class PokemonUi : Form
    {
        private Pokemon p149 = new Pokemon
        {
            index = 1,
            No = 149,
            CP = 266,
            HP = 182,
            HPcurrent = 182,
            NameCht = "快龍",
            NameEng = "Dragonite",
            vType = { "DRAGON", "FLYING" },
            Attack = 263,
            Defence = 201,
            Weight = 112.64,
            Height = 1.93,
            Candy = "DRATINI CANDY",
            PowerUpStardust = 400,
            PowerUpCandy = 2,
            EvolveAble = false,
            EvolveCandy = 0,
            EvolveNo = 0,
            exp = 0,
            Weakness = { "Ice", "Rock", "Dragon", "Fairy" },
            FastAttacks = { "Dragon Breath", "Steel Wing" },
            SpecialAttacks = { "Dragon Claw", "Dragon Pulse", "Hyper Beam" },
            PhotoUrl = @"D:\Study\296C#\296CSHARP\PokemonUi\images\149.png"
        };

        private Player player = new Player
        {
            PlayerName = "Jason",
            Stardust = 10000,
            Candy = { { "Candy", 100 }, { "DRATINI CANDY", 100 } }
        };

        public PokemonUi()
        {
            InitializeComponent();
            UpdateCtrl();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            if (player.Candy[p149.Candy] - p149.PowerUpCandy >= 0 && player.Stardust - p149.PowerUpStardust >= 0)
            {
                player.Candy[p149.Candy] -= p149.PowerUpCandy;
                player.Stardust -= p149.PowerUpStardust;
                UpdateCtrl();
            }
        }

        private void UpdateCtrl()
        {
            p149.SetInfo(NameCht: lblNameCht
                , CP: lblCPvalue, HP: lblHP
                , Height: lblHeightValue, Weight: lblWeightValue
                , Candy: lblCandy
                , PowerUpStardust: lblPwStardust
                , PowerUpCandy: lblPwCandy
                , EvolveCandy: lblEvCandy
                , imgPhoto: imgPhoto
                , Evolve: btnEvolve, Type: lblTypeValue);
            player.SetPlayerInfo(PowerUp: btnPowerUp, Stardust: lblStardustValue, Candy: lblCandyValue, CandyCate: p149.Candy, StardustRequire: p149.PowerUpStardust);
        }
    }

    public class Pokemon
    {
        public int index;
        public int No;
        public int CP;
        public int HP;
        public int HPcurrent;
        public string NameEng;
        public string NameCht;
        public List<string> vType = new List<string> { };
        public int Attack;
        public int Defence;
        public double Weight;
        public double Height;
        public string Candy;
        public int PowerUpStardust;
        public int PowerUpCandy;
        public bool EvolveAble;
        public int EvolveCandy;
        public int EvolveNo;
        public int exp;
        public List<string> Weakness = new List<string> { };
        public List<string> FastAttacks = new List<string> { };
        public List<string> SpecialAttacks = new List<string> { };
        public string PhotoUrl;

        public void SetInfo(Label NameCht
            , Label CP, Label HP
            , Label Weight, Label Height
            , Label Candy
            , Label PowerUpStardust, Label PowerUpCandy
            , Label EvolveCandy
            , PictureBox imgPhoto
            , Button Evolve
            , Label Type = null, Label SpecialAttacks = null)
        {
            NameCht.Text = this.NameCht;
            CP.Text = this.CP.ToString();
            HP.Text = string.Format("{0} / {1}", this.HPcurrent, this.HP);
            imgPhoto.ImageLocation = this.PhotoUrl;
            Height.Text = string.Format("{0} m", this.Height.ToString());
            Weight.Text = string.Format("{0} Kg", this.Weight.ToString());
            Candy.Text = this.Candy;
            PowerUpStardust.Text = this.PowerUpStardust.ToString();
            PowerUpCandy.Text = this.PowerUpCandy.ToString();
            EvolveCandy.Text = this.EvolveCandy.ToString();
            Evolve.Enabled = EvolveAble;
            if (SpecialAttacks != null)
            {
                SpecialAttacks.Text = string.Empty;
                foreach (string SpecialAttack in this.SpecialAttacks)
                {
                    if (SpecialAttacks.Text == string.Empty)
                    {
                        SpecialAttacks.Text += SpecialAttack;
                    }
                    else
                    {
                        SpecialAttacks.Text += " / " + SpecialAttack;
                    }
                }
            }
            if (Type != null)
            {
                Type.Text = string.Empty;
                foreach (string v in this.vType)
                {
                    if (Type.Text == string.Empty)
                    {
                        Type.Text += v;
                    }
                    else
                    {
                        Type.Text += " / " + v;
                    }
                }
            }
        }
    }

    public class Player
    {
        public string PlayerName;
        public int Stardust;
        public Dictionary<string, int> Candy = new Dictionary<string, int> { };

        public void SetPlayerInfo(Button PowerUp, Label Stardust, Label Candy, string CandyCate, int StardustRequire, Label PlayerName = null)
        {
            if (PlayerName != null)
                PlayerName.Text = this.PlayerName;
            Stardust.Text = this.Stardust.ToString();
            Candy.Text = this.Candy[CandyCate].ToString();

            PowerUp.Enabled = StardustRequire > this.Stardust ? false : true;
        }
    }
}