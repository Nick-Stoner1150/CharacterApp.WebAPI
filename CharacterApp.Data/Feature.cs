using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterApp.Data
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }

        public string SuperSpeed { get; set; }

        public string Phasing { get; set; }

        public string Magic { get; set; }

        public string Flight { get; set; }

        public string Telepathy { get; set; }

        public string Healing { get; set; }

        public string Invisibility { get; set; }

        public virtual List<Character> Characters { get; set; }
    }
}
