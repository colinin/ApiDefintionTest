using System.ComponentModel.DataAnnotations;

namespace ApiDefintionTest.Models
{
    public class GetValueInput
    {
        [Required]
        public string Id { get; set; }

        public string Optional1 { get; set; }

        public string Optional2 { get; set; }

        [Required]
        public string Required { get; set; }
    }
}
