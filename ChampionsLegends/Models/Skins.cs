using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionsLegends.Models
{
    public class Skins
    {

        public Skins()
        {
            //this.ListaFotos = new HashSet<FotosSkns>();
        }

        [Key] public int ID_Skin { get; set; }

        public string Nome { get; set; }

        public string Data_Lancamento { get; set; }

        public string Cor { get; set; }

        public string Foto { get; set; }

        [ForeignKey("Champion")] public int ChampionFK { get; set; }
        public virtual Champions Champion { get; set; }

        //public virtual ICollection<FotosSkns> ListaFotos { get; set; }
    }
}