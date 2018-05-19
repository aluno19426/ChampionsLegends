using System.Collections.Generic;
using ChampionsLegends.Models;

namespace ChampionsLegends.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChampionsLegends.Models.AppBD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ChampionsLegends.Models.AppBD context)
        {

            var cham = new List<Champions> {
                new Champions {ID_Champion = 1, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Irelia", Titulo = "the Blade Dancer", Role = "Fighter", Region = "Ionia", RelatedChampions = "Karma, Swain", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 2, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Fizz", Titulo = "Tidal Trickster", Role = "Assassin", Region = "Runeterra", RelatedChampions = "Nami, Nautilus", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] } */},

            };
            cham.ForEach (aa => context.Champions.AddOrUpdate (a => a.Nome,aa));
            context.SaveChanges ();

            var Abili = new List<Abilities>
            {
                new Abilities {ID_Abilidade = 1, Nome = "Ionian Fervor", ChampionFK = 1},
                new Abilities {ID_Abilidade = 2, Nome = "Bladesurge", Custo = "20", Range = 625,ChampionFK = 1},
                new Abilities {ID_Abilidade = 3, Nome = "Defiant Dance", Custo = "70/75/80/85/90", Range = 825,ChampionFK = 1},
                new Abilities {ID_Abilidade = 4, Nome = "Flawless Duet", Custo = "50", Range = 900,ChampionFK = 1},
                new Abilities {ID_Abilidade = 5, Nome = "Vanguard's Edge", Custo = "100",Range = 1000, ChampionFK = 1},

                new Abilities {ID_Abilidade = 6, Nome = "Nimble Fighter", ChampionFK = 2},
                new Abilities {ID_Abilidade = 7, Nome = "Urchin Strike", Custo = "50", Range = 550,ChampionFK = 2},
                new Abilities {ID_Abilidade = 8, Nome = "Seastone Trident", Custo =  "30/40/50/60/70 Mana", Range = 600,ChampionFK = 2},
                new Abilities {ID_Abilidade = 9, Nome = "Playful / Trickster", Custo = " 90/95/100/105/110 Mana", Range = 400,ChampionFK = 2},
                new Abilities {ID_Abilidade = 10, Nome = "Chum the Waters", Custo = "100",Range = 1300, ChampionFK = 2},


            };
            Abili.ForEach (aa => context.Abilities.AddOrUpdate (a => a.Nome,aa));
            context.SaveChanges ();

        }
    }
}
