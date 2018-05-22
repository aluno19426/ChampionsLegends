using ChampionsLegends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionsLegends.DTO.Champions {
    public class GetSingleChampion {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Titulo { get; set; }

        public string Historia { get; set; }

        public string Region { get; set; }

        public string Foto { get; set; }

        public string Role { get; set; }

        public string RelatedChampions { get; set; }

        public virtual ICollection<Abilities> ListaAbilities { get; set; }
        public virtual ICollection<Skins> ListaSkins { get; set; }


        public ICollection<AbilitiesSingleChamp> Abilities { get; set; }
        public ICollection<SkinsSingleChamp> Skins { get; set; }

    }

    public class SkinsSingleChamp {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Data_Lancamento { get; set; }

        public string Cor { get; set; }

        public string Foto { get; set; }
    }

    public class AbilitiesSingleChamp {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Custo { get; set; }

        public int Range { get; set; }
    }
}