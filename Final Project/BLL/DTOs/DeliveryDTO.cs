using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DeliveryDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Date { get; set; }
        public double Distance { get; set; }
    }
}
