using System.ComponentModel.DataAnnotations;

namespace CarRadioCompanion
{
    public class Radiosender
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
