using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharacterApp.WebAPI.Models
{
    public class TeamCreate
    {
        [Required]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }
    }
}