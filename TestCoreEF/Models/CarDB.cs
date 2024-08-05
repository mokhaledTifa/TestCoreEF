using System.ComponentModel.DataAnnotations;
using TestCoreEF.DTOs;

namespace TestCoreEF.Models
{
    public class CarDB
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        
    }
}
