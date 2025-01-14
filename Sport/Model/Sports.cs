using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;


namespace Sports_Web.Sport.Model
{
    [Table("sports")]
    public class Sports
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]

        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("GameTime")]
        public double GameTime { get; set; }

        [Required]
        [Column("Date")]
        public DateOnly Date { get; set; }

        [Required]
        [Column("NrPlayers")]
        public int NrPlayers { get; set; }










    }
}
