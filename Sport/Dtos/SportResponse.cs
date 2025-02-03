namespace Sports_Web.Sport.Dtos
{
    public class SportResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GameTime { get; set; }
        public DateOnly Date { get; set; }
        public int NrPlayers { get; set; }

    }
}
