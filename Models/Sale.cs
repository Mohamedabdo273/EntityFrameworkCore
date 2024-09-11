using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateOnly date { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
