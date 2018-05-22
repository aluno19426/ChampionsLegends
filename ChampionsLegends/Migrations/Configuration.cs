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
                new Champions {ID_Champion = 3, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Orianna", Titulo = "the Lady of Clockwork", Role = "Mage", Region = "Piltolver", RelatedChampions = "Blitzcrank, Akali, Viktor", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 4, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Ahri", Titulo = "the Nine-Tailed Fox", Role = "Mage", Region = "Ionia", RelatedChampions = "Wukong", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 5, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Jinx", Titulo = "the Loose Cannon", Role = "Marksman", Region = "Zaun", RelatedChampions = "Caitlyn,Vi,Ekko", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 6, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Sivir", Titulo = "the Battle Mistress", Role = "Marksman", Region = "Shurima", RelatedChampions = "BNasus,Cassiopeia,Azir", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 7, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Olaf", Titulo = "the Berserker", Role = "Fighter", Region = "Freljord", RelatedChampions = "Sejuani,Volibear,Miss Fortune", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 8, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Jarvan IV", Titulo = "the Exemplar of Demacia", Role = "Tank", Region = "Demacia", RelatedChampions = "Garen,Shyvana,Quinn", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 9, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Caitlyn", Titulo = "Sheriff of Piltover", Role = "Marksman", Region = "Piltolver", RelatedChampions = "Akali,Jayce,Ezreal", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },
                new Champions {ID_Champion = 10, Foto = "teste.jpg", Historia = "sadasdsa", Nome = "Lee Sin", Titulo = "the Blind Monk", Role = "Fighter", Region = "Ionia", RelatedChampions = "Karma,Udyr", /*ListaAbilidades = new List<Abilities> {Abili[0],Abili[1],Abili[2],Abili[3],Abili[4] }*/ },


            };
            cham.ForEach (aa => context.Champions.AddOrUpdate (a => a.Nome,aa));
            context.SaveChanges ();

            var Abili = new List<Abilities>
            {

                /***Irelia***/
                new Abilities {ID_Abilities = 1, Nome = "Ionian Fervor", ChampionFK = 1},
                new Abilities {ID_Abilities = 2, Nome = "Bladesurge", Custo = "20", Range = 625,ChampionFK = 1},
                new Abilities {ID_Abilities = 3, Nome = "Defiant Dance", Custo = "70/75/80/85/90", Range = 825,ChampionFK = 1},
                new Abilities {ID_Abilities = 4, Nome = "Flawless Duet", Custo = "50", Range = 900,ChampionFK = 1},
                new Abilities {ID_Abilities = 5, Nome = "Vanguard's Edge", Custo = "100",Range = 1000, ChampionFK = 1},

                /***Fizz***/
                new Abilities {ID_Abilities = 6, Nome = "Nimble Fighter", ChampionFK = 2},
                new Abilities {ID_Abilities = 7, Nome = "Urchin Strike", Custo = "50", Range = 550,ChampionFK = 2},
                new Abilities {ID_Abilities = 8, Nome = "Seastone Trident", Custo =  "30/40/50/60/70 Mana", Range = 600,ChampionFK = 2},
                new Abilities {ID_Abilities = 9, Nome = "Playful / Trickster", Custo = " 90/95/100/105/110 Mana", Range = 400,ChampionFK = 2},
                new Abilities {ID_Abilities = 10, Nome = "Chum the Waters", Custo = "100",Range = 1300, ChampionFK = 2},

                /***Orianna******/
                new Abilities {ID_Abilities = 11, Nome = "Clockwork Windup", ChampionFK = 3},
                new Abilities {ID_Abilities = 12, Nome = "Command: Attack", Custo = "30/35/40/45/50 Mana", Range = 815,ChampionFK = 3},
                new Abilities {ID_Abilities = 13, Nome = "Command: Dissonance", Custo =  "70/80/90/100/110 Mana", Range = 255,ChampionFK = 3},
                new Abilities {ID_Abilities = 14, Nome = "Command: Protect", Custo = "60 Mana", Range = 1095,ChampionFK = 3},
                new Abilities {ID_Abilities = 15, Nome = "Command: Shockwave", Custo = "100",Range = 410, ChampionFK = 3},

                /***Ahri***/

                new Abilities {ID_Abilities = 16, Nome = "Vastayan Grace", ChampionFK = 4},
                new Abilities {ID_Abilities = 17, Nome = "Orb of Deception", Custo = "65/70/75/80/85 Mana", Range = 880,ChampionFK = 4},
                new Abilities {ID_Abilities = 18, Nome = "Fox-Fire", Custo =  "40 Mana", Range = 700,ChampionFK = 4},
                new Abilities {ID_Abilities = 19, Nome = "Charm", Custo = "85 Mana", Range = 975,ChampionFK = 4},
                new Abilities {ID_Abilities = 20, Nome = "Spirit Rush", Custo = "100 Mana",Range = 450, ChampionFK = 4},

                /****Jinx******/

                new Abilities {ID_Abilities = 21, Nome = "Get Excited!", ChampionFK = 5},
                new Abilities {ID_Abilities = 22, Nome = "Switcheroo!", Custo = "20 Mana per Rocket", Range = 600,ChampionFK = 5},
                new Abilities {ID_Abilities = 23, Nome = "Zap!", Custo =  "50/60/70/80/90 Mana", Range = 1450,ChampionFK = 5},
                new Abilities {ID_Abilities = 24, Nome = "Flame Chompers!", Custo = "70 Mana", Range = 900,ChampionFK = 5},
                new Abilities {ID_Abilities = 25, Nome = "Super Mega Death Rocket!", Custo = "100 Mana",Range = 25000, ChampionFK = 5},


                /***Sivir***/
                new Abilities {ID_Abilities = 26, Nome = "Fleet of Foot", ChampionFK = 6},
                new Abilities {ID_Abilities = 27, Nome = "Boomerang Blade", Custo = "70/80/90/100/110 Mana", Range = 1200,ChampionFK = 6},
                new Abilities {ID_Abilities = 28, Nome = "Ricochet!", Custo =  " 60 Mana", Range = 20,ChampionFK = 6},
                new Abilities {ID_Abilities = 29, Nome = "Spell Shield", Custo = "No Cost", Range = 20,ChampionFK = 6},
                new Abilities {ID_Abilities = 30, Nome = "On The Hunt", Custo = "100 Mana",Range = 1000, ChampionFK = 6},

                /***Olaf***/

                new Abilities {ID_Abilities = 31, Nome = "Berserker Rage", ChampionFK = 7},
                new Abilities {ID_Abilities = 32, Nome = "BUndertow", Custo = "60 Mana", Range = 1000,ChampionFK = 7},
                new Abilities {ID_Abilities = 33, Nome = "Vicious Strikes", Custo =  "30 Mana", Range = 700,ChampionFK = 7},
                new Abilities {ID_Abilities = 34, Nome = "Reckless Swing", Custo = "Health", Range = 325,ChampionFK = 7},
                new Abilities {ID_Abilities = 35, Nome = "Ragnarok", Custo = "No Cost",Range = 400, ChampionFK = 7},


                /*****Jarvan IV**/
                new Abilities {ID_Abilities = 36, Nome = "Martial Cadence", ChampionFK = 8},
                new Abilities {ID_Abilities = 37, Nome = "Dragon Strike", Custo = "45/50/55/60/65 Mana", Range = 770,ChampionFK = 8},
                new Abilities {ID_Abilities = 38, Nome = "Golden Aegis", Custo =  "30 Mana", Range = 625,ChampionFK = 8},
                new Abilities {ID_Abilities = 39, Nome = "Demacian Standard", Custo = " 55 Mana", Range = 860,ChampionFK = 8},
                new Abilities {ID_Abilities = 40, Nome = "Cataclysm", Custo = "100 Mana",Range = 650, ChampionFK = 8},


                /***Caitlyn**/

                new Abilities {ID_Abilities = 41, Nome = "Headshot", ChampionFK = 9},
                new Abilities {ID_Abilities = 42, Nome = "Piltover Peacemaker", Custo = "50/60/70/80/90 Mana", Range = 1250,ChampionFK = 9},
                new Abilities {ID_Abilities = 43, Nome = "Yordle Snap Trap", Custo =  "20 Mana", Range = 800,ChampionFK = 9},
                new Abilities {ID_Abilities = 44, Nome = "90 Caliber Net", Custo = " 75 Mana", Range = 750,ChampionFK = 9},
                new Abilities {ID_Abilities = 45, Nome = "Ace in the Hole", Custo = "100 Mana",Range = 2000/2500/3000, ChampionFK = 9},

                /*****Lee Sin****/

                new Abilities {ID_Abilities = 42, Nome = "Flurry", ChampionFK = 10},
                new Abilities {ID_Abilities = 43, Nome = "Sonic Wave / Resonating Strike", Custo = "50 Energy / 30 Energy", Range = 1100,ChampionFK = 10},
                new Abilities {ID_Abilities = 44, Nome = "Safeguard / Iron Will", Custo =  "50 Energy / 30 Energy", Range = 700,ChampionFK = 10},
                new Abilities {ID_Abilities = 44, Nome = "Tempest / Cripple", Custo = "50 Energy / 30 Energy", Range = 425,ChampionFK = 10},
                new Abilities {ID_Abilities = 45, Nome = "Dragon's Rage", Custo = "No Cost",Range = 375, ChampionFK = 10},


            };
            Abili.ForEach (aa => context.Abilities.AddOrUpdate (a => a.Nome,aa));
            context.SaveChanges ();


            var skin = new List<Skins> {

                new Skins {ID_Skin = 1, Nome = "Classic Irelia", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "16-Nov-2010", ChampionFK = 1},
                new Skins {ID_Skin = 2, Nome = "Nightblade Irelia", Foto = "teste.jpg", Cor = "Preto", Data_Lancamento = "16-Nov-2010", ChampionFK = 1},
                new Skins {ID_Skin = 3, Nome = "Aviator Irelia", Foto = "teste.jpg", Cor = "Castanho", Data_Lancamento = "16-Nov-2010", ChampionFK = 1},
                new Skins {ID_Skin = 4, Nome = "Frostblade Irelia", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "01-May-2012", ChampionFK = 1},
                new Skins {ID_Skin = 5, Nome = "Order of the Lotus Irelia", Foto = "teste.jpg", Cor = "Rosa", Data_Lancamento = "04-Jun-2015", ChampionFK = 1},


                /****Fizz****/
                new Skins {ID_Skin = 6, Nome = "Classic Fizz", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "16-Nov-2010", ChampionFK = 2},
                new Skins {ID_Skin = 7, Nome = "Atlantean Fizz ", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "16-Nov-2010", ChampionFK = 2},
                new Skins {ID_Skin = 8, Nome = "Tundra Fizz", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "16-Nov-2010", ChampionFK = 2},
                new Skins {ID_Skin = 9, Nome = "Fisherman Fizz", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "01-May-2012", ChampionFK = 2},
                new Skins {ID_Skin = 10, Nome = "Void Fizz ", Foto = "teste.jpg", Cor = "Roxo", Data_Lancamento = "04-Jun-2015", ChampionFK = 2},
                new Skins {ID_Skin = 11, Nome = "Cottontail Fizz", Foto = "teste.jpg", Cor = "Azul/Branco", Data_Lancamento = "16-Nov-2010", ChampionFK = 2},
                new Skins {ID_Skin = 12, Nome = "Super Galaxy Fizz", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "26-May-2016", ChampionFK = 2},
                new Skins {ID_Skin = 13, Nome = "Omega Squad Fizz", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "27-Jul-2017", ChampionFK = 2},

                /******Orianna*******/
                new Skins {ID_Skin = 14, Nome = "Classic Orianna", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "1-Jun-2010", ChampionFK = 3},
                new Skins {ID_Skin = 15, Nome = "Gothic Orianna", Foto = "teste.jpg", Cor = "Roxo", Data_Lancamento = "1-Jun-2010", ChampionFK = 3},
                new Skins {ID_Skin = 16, Nome = "Sewn Chaos", Foto = "teste.jpg", Cor = "Verde e Roxo", Data_Lancamento = "1-Jun-2010", ChampionFK = 3},
                new Skins {ID_Skin = 17, Nome = "Bladecraft Orianna", Foto = "teste.jpg", Cor = "Preto", Data_Lancamento = "29-Feb-2012", ChampionFK = 3},
                new Skins {ID_Skin = 18, Nome = "Dark Star Orianna", Foto = "teste.jpg", Cor = "Roxo", Data_Lancamento = "05-Apr-2017", ChampionFK = 3},

                /****Ahri***/
                new Skins {ID_Skin = 19, Nome = "Classic Ahri", Foto = "teste.jpg", Cor = "Vermelho e Branco", Data_Lancamento = "14-Dec-2011", ChampionFK = 4},
                new Skins {ID_Skin = 20, Nome = "Dynasty Ahri", Foto = "teste.jpg", Cor = "Roso e Branco", Data_Lancamento = "14-Dec-2011", ChampionFK = 4},
                new Skins {ID_Skin = 21, Nome = "Midnight Ahri", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "14-Dec-2011", ChampionFK = 4},
                new Skins {ID_Skin = 22, Nome = "Foxfire Ahri", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "11-Jul-2012", ChampionFK = 4},
                new Skins {ID_Skin = 23, Nome = "Popstar Ahri", Foto = "teste.jpg", Cor = "Rosa", Data_Lancamento = "25-Nov-2013", ChampionFK = 4},
                new Skins {ID_Skin = 24, Nome = "Academy Ahri", Foto = "teste.jpg", Cor = "Azul/Branco", Data_Lancamento = "27-Aug-2015", ChampionFK = 4},
                new Skins {ID_Skin = 25, Nome = "Arcade Ahri", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "26-May-2016", ChampionFK = 4},
                new Skins {ID_Skin = 26, Nome = "Star Guardian Ahri", Foto = "teste.jpg", Cor = "Branco e Vermelho", Data_Lancamento = " 07-Sep-2017", ChampionFK = 4 },

                /***Jinx***/
                new Skins {ID_Skin = 27, Nome = "Classic Jinx", Foto = "teste.jpg", Cor = "Azul e Rosa", Data_Lancamento = "10-Oct-2013", ChampionFK = 5},
                new Skins {ID_Skin = 28, Nome = "Mafia Jinx", Foto = "teste.jpg", Cor = "Rosa", Data_Lancamento = "10-Oct-2013", ChampionFK = 5},
                new Skins {ID_Skin = 29, Nome = "Firecracker Jinx", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "10-Feb-2015", ChampionFK = 5},
                new Skins {ID_Skin = 30, Nome = "Star Guardian Jinx", Foto = "teste.jpg", Cor = "Branco", Data_Lancamento = "06-Oct-2016", ChampionFK = 5},

                /***Sivir***/
                new Skins {ID_Skin = 31, Nome = "Classic Sivir", Foto = "teste.jpg", Cor = "Amarelo", Data_Lancamento = "27-Oct-2009", ChampionFK = 6},
                new Skins {ID_Skin = 32, Nome = "Warrior Princess Sivir", Foto = "teste.jpg", Cor = "Rosa", Data_Lancamento = "27-Apr-2010", ChampionFK = 6},
                new Skins {ID_Skin = 33, Nome = "Huntress Sivir", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "07-Feb-2011", ChampionFK = 6},
                new Skins {ID_Skin = 34, Nome = "Bandit Sivir", Foto = "teste.jpg", Cor = "Branco", Data_Lancamento = "21-Mar-2011", ChampionFK = 6},
                
                /**Olaf**/
                new Skins {ID_Skin = 35, Nome = "Classic Olaf", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "08-Jun-2010", ChampionFK = 7},
                new Skins {ID_Skin = 36, Nome = "Brolaf", Foto = "teste.jpg", Cor = "Verde e Azul", Data_Lancamento = "01-Dec-2010", ChampionFK = 7},

                /**Jarvan IV**/
                new Skins {ID_Skin = 37, Nome = "Classic Jarvan IV", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "01-Mar-2011", ChampionFK = 8},
                new Skins {ID_Skin = 38, Nome = "Victorious Jarvan IV", Foto = "teste.jpg", Cor = "Cinzento", Data_Lancamento = "23-Aug-2011", ChampionFK = 8},

                /**Caitlyn **/
                new Skins {ID_Skin = 39, Nome = "Classic Caitlyn", Foto = "teste.jpg", Cor = "Azul", Data_Lancamento = "01-Jan-2011", ChampionFK = 9},
                new Skins {ID_Skin = 40, Nome = "Pulsefire Caitlyn", Foto = "teste.jpg", Cor = "Cinzento", Data_Lancamento = "23-Aug-2011", ChampionFK = 9},
              
                /**Lee Sin **/
                new Skins {ID_Skin = 41, Nome = "Classic Lee Sin", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "01-Apr-2011", ChampionFK = 10},
                new Skins {ID_Skin = 42, Nome = "Muay Thai Lee Sin", Foto = "teste.jpg", Cor = "Vermelho", Data_Lancamento = "24-Jul-2012", ChampionFK = 10},

            };
            skin.ForEach (aa => context.Skins.AddOrUpdate (a => a.Nome,aa));
            context.SaveChanges ();

        }
    }
}
