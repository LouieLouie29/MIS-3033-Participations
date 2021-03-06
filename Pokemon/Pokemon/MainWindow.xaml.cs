using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            foreach (var item in api.results.OrderBy(x => x.name).ToList())
            {
                lstPokemon.Items.Add(item);                
            }

            foreach (var item in api.results.OrderBy(x => x.height).ToList())
            {
                lstHeight.Items.Add(item);
            }
            /*
            foreach (var item in api.results.OrderBy(a => a.height.ToList())
            {

            }
            */
        }
    }
}
