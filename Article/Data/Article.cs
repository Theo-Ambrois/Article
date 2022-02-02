using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Data
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public float Prix { get; set; }
        public bool Disponible { get; set; }
    }
}