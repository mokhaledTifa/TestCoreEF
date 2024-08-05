using System.ComponentModel.DataAnnotations;

namespace TestCoreEF.DTOs
{
    public class CarDto
    {
        [Required]
        public string Name { get; set; }
    }
}
