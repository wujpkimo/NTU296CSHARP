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
        private int seq = 0;

        private Pokemon p147 = new Pokemon
        {
            index = 0,
            No = 147,
            CP = 266,
            MaxCP = 860,
            HP = 82,
            HPcurrent = 82,
            NameCht = "迷你龍",
            NameEng = "Dratini",
            vType = { "DRAGON" },
            Attack = 119,
            Defence = 94,
            Weight = 4.53,
            Height = 2.14,
            Candy = "DRATINI CANDY",
            PowerUpStardust = 1600,
            PowerUpCandy = 2,
            EvolveAble = true,
            EvolveCandy = 25,
            EvolveNo = 148,
            exp = 0,
            Weakness = { "Ice", "Dragon", "Fairy" },
            FastAttacks = { "Dragon Breath" },
            SpecialAttacks = { "Twister", "Wrap", "Aqya Tail" },
            PhotoUrl = @"D:\Study\296C#\296CSHARP\PokemonUi\images\dratini-pokemon-go.png"
        };

        private Pokemon p148 = new Pokemon
        {
            index = 0,
            No = 148,
            CP = 513,
            MaxCP = 1609,
            HP = 80,
            HPcurrent = 80,
            NameCht = "哈克龍",
            NameEng = "Dragonair",
            vType = { "DRAGON" },
            Attack = 263,
            Defence = 201,
            Weight = 16.5,
            Height = 3.92,
            Candy = "DRATINI CANDY",
            PowerUpStardust = 2500,
            PowerUpCandy = 2,
            EvolveAble = true,
            EvolveCandy = 100,
            EvolveNo = 149,
            exp = 0,
            Weakness = { "Ice", "Dragon", "Fairy" },
            FastAttacks = { "Dragon Breath", "Steel Wing" },
            SpecialAttacks = { "Dragon Claw", "Dragon Pulse", "Hyper Beam" },
            PhotoUrl = @"D:\Study\296C#\296CSHARP\PokemonUi\images\Dragonair-Pokemon-Go.png"
        };

        private Pokemon p149 = new Pokemon
        {
            index = 2,
            No = 149,
            CP = 631,
            MaxCP = 3581,
            HP = 123,
            HPcurrent = 123,
            NameCht = "快龍",
            NameEng = "Dragonite",
            vType = { "DRAGON", "FLYING" },
            Attack = 263,
            Defence = 201,
            Weight = 232.47,
            Height = 2.28,
            Candy = "DRATINI CANDY",
            PowerUpStardust = 3000,
            PowerUpCandy = 3,
            EvolveAble = false,
            EvolveCandy = 0,
            EvolveNo = 0,
            exp = 0,
            Weakness = { "Ice", "Rock", "Dragon", "Fairy" },
            FastAttacks = { "Dragon Breath", "Steel Wing" },
            SpecialAttacks = { "Dragon Claw", "Dragon Pulse", "Hyper Beam" },
            PhotoUrl = @"D:\Study\296C#\296CSHARP\PokemonUi\images\149.png"
        };

        public List<Pokemon> pokemonList = new List<Pokemon>();

        private Player player = new Player
        {
            PlayerName = "Jason",
            Stardust = 500000,
            Candy = { { "Candy", 100 }, { "DRATINI CANDY", 500 } }
        };

        private Dictionary<string, string> candy = new Dictionary<string, string> {
            { "DRATINI CANDY",@"D:\Study\296C#\296CSHARP\PokemonUi\images\Dratini_candy.png"},
            { "EEVEE CANDY",@"D:\Study\296C#\296CSHARP\PokemonUi\images\EeveeCandy.jpg"}
        };

        public PokemonUi()
        {
            InitializeComponent();
            pokemonList.Add(p147);
            pokemonList.Add(p148);
            pokemonList.Add(p149);
            UpdateCtrl(pokemonList[seq]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            if (player.Candy[pokemonList[seq].Candy] - pokemonList[seq].PowerUpCandy >= 0 && player.Stardust - pokemonList[seq].PowerUpStardust >= 0)
            {
                if (pokemonList[seq].CP <= pokemonList[seq].MaxCP)
                {
                    if (pokemonList[seq].MaxCP - pokemonList[seq].CP < 50)
                    {
                        pokemonList[seq].CP = pokemonList[seq].MaxCP;
                    }
                    else
                        pokemonList[seq].CP += 50;
                    player.Candy[pokemonList[seq].Candy] -= pokemonList[seq].PowerUpCandy;
                    player.Stardust -= pokemonList[seq].PowerUpStardust;
                    UpdateCtrl(pokemonList[seq]);
                }
            }
        }

        private void UpdateCtrl(Pokemon pokemon)
        {
            pokemon.SetInfo(NameCht: lblNameCht
                , CP: lblCPvalue, HP: lblHP
                , Height: lblHeightValue, Weight: lblWeightValue
                , Candy: lblCandy
                , PowerUpStardust: lblPwStardust
                , PowerUpCandy: lblPwCandy
                , EvolveCandy: lblEvCandy
                , imgPhoto: imgPhoto
                , Evolve: btnEvolve, Type: lblTypeValue);
            player.SetPlayerInfo(PowerUp: btnPowerUp, Stardust: lblStardustValue, Candy: lblCandyValue, CandyCate: pokemon.Candy, StardustRequire: pokemon.PowerUpStardust);
            imgCandy.ImageLocation = imgCandy2.ImageLocation = candy[pokemon.Candy];
            if (int.Parse(lblStardustValue.Text) >= pokemon.PowerUpStardust)
                btnPowerUp.Enabled = pokemon.CP != pokemon.MaxCP ? true : false;
            btnPrevious.Enabled = seq != 0 ? true : false;
            btnNext.Enabled = seq != (pokemonList.Count() - 1) ? true : false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            seq++;
            UpdateCtrl(pokemonList[seq]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            seq--;
            UpdateCtrl(pokemonList[seq]);
        }

        private void btnEvolve_Click(object sender, EventArgs e)
        {
            int evo = pokemonList[seq].EvolveNo;

            foreach (Pokemon x in pokemonList)
            {
                if (x.No == evo)
                {
                    pokemonList[seq] = x;
                    break;
                }
            }

            UpdateCtrl(pokemonList[seq]);
        }
    }

    public class Pokemon
    {
        public int index;
        public int No;
        public int CP;
        public int HP;
        public int MaxCP;
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