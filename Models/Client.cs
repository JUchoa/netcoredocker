using System.ComponentModel.DataAnnotations;

namespace netcoredocker.Models
{
    public class Client
    {
        public int ID {get; set;}
        [Required]
        public string Name {get; set;}

        public string Type {get; set;}

    }
}