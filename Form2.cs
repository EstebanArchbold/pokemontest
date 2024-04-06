using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemontest
{
    public partial class Form2 : Form
    {
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Form2()
        {
            InitializeComponent();
            LoadPokemonData();
            //PopulateListView();
            PopulateListBox();
            //LoadMoveData();
            //PopulateListBox2();
        }

        private void LoadPokemonData()
        {
            // Lee el archivo JSON
            string json = File.ReadAllText("../../pokemon.json");

            // Deserializa el JSON en una lista de objetos Pokemon
            pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
        }

        private void PopulateListBox()
        {
            // Limpiar el ListBox antes de agregar elementos
            listBox1.Items.Clear();

            //Agregar cada Pokemon al ListBox
            foreach (Pokemon pokemon in pokemons)
            {
                // Formatear el texto para cada Pokemon
                string pokemonInfo = $"{pokemon.Name} - HP: {pokemon.HP}, Attack: {pokemon.Attack}";

                // Agregar el Pokemon al ListBox
                listBox1.Items.Add(pokemonInfo);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
