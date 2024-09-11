using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string StoreName { get; set; }
        public decimal Sales { get; set; }
        public ICollection<Sale> Sale { get; set; } = new HashSet<Sale>();
    }
}
