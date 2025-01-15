using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sports_Web.Sport.Dtos
{
    public class CreateSportRequest
    {
       
        public string Name { get; set; }
        public double GameTime { get; set; }
        public DateOnly Date { get; set; }
        public int NrPlayers { get; set; }


    }
}
