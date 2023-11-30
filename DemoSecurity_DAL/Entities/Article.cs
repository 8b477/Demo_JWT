using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSecurity_DAL.Entities
{
    public class Article
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Prix { get; set; }

        public string Categorie { get; set; }

        public string Description { get; set; }
    }
}
