using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionsLegends.Models {
    public class FotosSkns {

        [Key]
        public int ID_Foto { get; set; }

        public string Fotos_Skins { get; set; }

        [ForeignKey ("Skin")]
        public int SkinFK { get; set; }
        public virtual Skins Skin { get; set; }

    }
}