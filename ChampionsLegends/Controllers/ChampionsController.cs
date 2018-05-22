using ChampionsLegends.DTO;
using ChampionsLegends.DTO.Champions;
using ChampionsLegends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;

namespace ChampionsLegends.Controllers
{
    public class ChampionsController : ApiController
    {
        private AppBD appBD = new AppBD ();

        [HttpGet, Route("api/champions")]
        public IHttpActionResult GetChamps () {


            var champions = appBD.Champions
                .Select(c => new GetChampions {
                    Nome = c.Nome,
                    Id = c.ID_Champion
                })
                .OrderBy(c=> c.Nome)
                .ToList();


            if (champions == null) {
               return NotFound();
            }

            return Ok(champions);
        }


        [HttpGet, Route ("api/champions/{id}")]
        public IHttpActionResult GetChamps (int? id) {


            if (id == null) {
               return BadRequest ();
            }


            var champion = appBD.Champions
                .Include(c => c.ListaAbilities)
                .Include(c => c.ListaSkins)
                .Where (c => c.ID_Champion == id)
                .Select (c => new GetSingleChampion {
                    Nome = c.Nome,
                    Id = c.ID_Champion,
                    ListaAbilities = c.ListaAbilities
                        .ToList(),
                        //.Select(a => new Abilities 
                        //{
                        //    ID_Abilities = a.ID_Abilities,
                        //    Nome = a.Nome,
                        //    Custo = a.Custo,
                        //    Range = a.Range
                        //}).ToList (),
                    Foto = c.Foto,
                    Historia = c.Historia,
                    ListaSkins = c.ListaSkins
                        .ToList(),
                        //.Select (s => new Skins 
                        //{
                        //    ID_Skin = s.ID_Skin,
                        //    Nome = s.Nome,
                        //    Cor = s.Cor,
                        //    Foto = s.Foto,
                        //    Data_Lancamento = s.Data_Lancamento
                        //}).ToList (),
                    Region = c.Region,
                    RelatedChampions = c.RelatedChampions,
                    Role = c.Role,
                    Titulo = c.Titulo
                }).FirstOrDefault();


            if(champion == null) {
                return NotFound ();
            }

            return Ok (champion);
        }


    }
}
