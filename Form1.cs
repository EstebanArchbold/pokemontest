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
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons = new List<Pokemon>();




        public Form1()
        {
            InitializeComponent();
            LoadPokemonData();
            PopulateListView();
            PopulateListBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica si hay un elemento seleccionado en el listBox1
            if (listBox1.SelectedIndex != -1)
            {
                // Obtiene el Pokemon seleccionado en el listBox1
                Pokemon selectedPokemon = (Pokemon)listBox1.SelectedItem;

                // Muestra los datos del Pokemon seleccionado en otros controles
                textBox1.Text = selectedPokemon.Name;
                textBox2.Text = selectedPokemon.HP.ToString();
                textBox3.Text = selectedPokemon.Attack.ToString();
            }

        }





        private void LoadPokemonData()
        {
            // Lee el archivo JSON
            string json = File.ReadAllText("../../pokemon.json");

            // Deserializa el JSON en una lista de objetos Pokemon
            pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
        }

        private void PopulateListView()
        {
            // Asegúrate de que el ListView esté configurado para mostrar datos en detalles
            listView1.View = View.Details;

            // Agrega las columnas al ListView
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("HP", 50);
            listView1.Columns.Add("Attack", 50);

            // Agrega cada Pokemon como un ListViewItem al ListView
            foreach (var pokemon in pokemons)
            {
                ListViewItem item = new ListViewItem(pokemon.Name);
                item.SubItems.Add(pokemon.HP.ToString());
                item.SubItems.Add(pokemon.Attack.ToString());
                listView1.Items.Add(item);
            }
        }

        private void PopulateListBox()
        {
            // Limpiar el ListBox antes de agregar elementos
            listBox1.Items.Clear();

            // Agregar cada Pokemon al ListBox
            foreach (var pokemon in pokemons)
            {
                // Formatear el texto para cada Pokemon
                string pokemonInfo = $"{pokemon.Name} - HP: {pokemon.HP}, Attack: {pokemon.Attack}";

                // Agregar el Pokemon al ListBox
                listBox1.Items.Add(pokemonInfo);
            }
        }
    }
}
