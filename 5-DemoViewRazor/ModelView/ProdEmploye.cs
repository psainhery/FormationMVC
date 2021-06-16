using _5_DemoViewRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_DemoViewRazor.ModelView
{
    public class ProdEmploye
    {
        public Employe Employe { get; set; }
        public Produit Produit { get; set; }
    }
}