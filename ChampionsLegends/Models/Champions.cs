using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ChampionsLegends.Models {
    public class Champions {

        public Champions()
        {
            this.ListaAbilidades = new HashSet<Abilities>();
            this.ListaSkins = new HashSet<Skins>();
        }


        [Key]
        public int ID_Champion { get; set; }

        public string Nome { get; set; }

        public string Titulo { get; set; }

        public string Historia { get; set; }

        public string Region {get;set;}

        public string Foto { get; set; }

        public string Role { get; set; }

        public string RelatedChampions { get; set; }

        public virtual ICollection<Abilities> ListaAbilidades { get; set; }
        public virtual ICollection<Skins> ListaSkins { get; set; }
    }
}