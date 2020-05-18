using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models.ViewModel
{
    public class ParcaViewModel
    {
        public Parca Prc { get; set; }
        public IEnumerable<Parca> Parcalar { get; set; }
    }
}