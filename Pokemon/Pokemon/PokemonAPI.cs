using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public class PokemonAPI
    {
        public List<ResultObject> results { get; set; }

    }

    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }
        
        public int height { get; set; }

        public double weight { get; set; }


        public override string ToString()
        {
            return name;
        }
    }


}
