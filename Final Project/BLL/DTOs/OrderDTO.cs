using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public System.DateTime Creation { get; set; }
        public Nullable<System.DateTime> Expiration { get; set; }
        public int UserId { get; set; }
    }
}
