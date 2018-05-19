using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionsLegends.Models {
    public class Abilities {

        [Key]
        public int ID_Abilidade { get; set; }

        public string Nome { get; set; }

        public string Custo { get; set; }

        public int Range { get; set; }

        [ForeignKey ("Champion")]
        public int ChampionFK { get; set; }
        public virtual Champions Champion { get; set; }

    }
}