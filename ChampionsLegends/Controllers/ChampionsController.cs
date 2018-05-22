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
using System.Drawing;
using System.Web.Http.Results;

namespace ChampionsLegends.Controllers
{
    public class ChampionsController : ApiController
    {
        private readonly AppBD _appBd = new AppBD ();

        [HttpGet, Route("api/champions")]
        public IHttpActionResult GetChamps () {


            var champions = _appBd.Champions
                .Select(c => new GetChampions {
                    Nome = c.Nome,
                    Id = c.ID_Champion
                })
                .OrderBy(c=> c.Nome)
                .ToList();


            if (champions.Count == 0) {
               return NotFound();
            }

            return Ok(champions);
        }


        [HttpGet, Route ("api/champions/{id:int}")]
        public IHttpActionResult GetChamps (int? id) {


            if (id == null) {
               return BadRequest ();
            }


            var champion = _appBd.Champions
                .Where (c => c.ID_Champion == id)
                .Include (c => c.ListaAbilities)
                .Include(c => c.ListaSkins)
                .Select(c => new GetSingleChampion 
                {
                    Id = c.ID_Champion,
                    Nome = c.Nome,
                    Abilities = c.ListaAbilities
                        .Select(a => new GetSingleChampion.AbilitiesSingleChamp {
                            Id = a.ID_Abilities,
                            Nome = a.Nome,
                            Custo = a.Custo,
                            Range = a.Range
                        })
                        .ToList(),
                    Foto = c.Foto,
                    Historia = c.Historia,
                    Skins = c.ListaSkins
                        .Select(s => new GetSingleChampion.SkinsSingleChamp {
                            Id = s.ID_Skin,
                            Nome = s.Nome,
                            Cor = s.Cor,
                            Foto = s.Foto,
                            Data_Lancamento = s.Data_Lancamento
                        })
                        .ToList(),
                    Region = c.Region,
                    RelatedChampions = c.RelatedChampions,
                    Role = c.Role,
                    Titulo = c.Titulo
                })
                .FirstOrDefault();

            if(champion == null)
            {
                return NotFound();
            }

            return Ok (champion);
        }
    }
}
