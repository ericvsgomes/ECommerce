using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Gender { get; set; }
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? MotherName { get; set; }
        public string? FatherName { get; set; }
        public string? RecordStatus { get; set; }
        public DateTimeOffset RecordDate { get; set; }
        public Contact? Contact { get; set; }
        public ICollection<DeliveryAddress>? DeliveryAddresses { get; set;}
        public ICollection<Department>? Departments { get; set;}
    }
}