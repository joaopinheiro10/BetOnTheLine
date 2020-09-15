namespace db.Model
{
    public class Tip
    {
        public int id { get; set; }

        public string homeTeam { get; set; }

        public string awayTeam { get; set; }

        public int user_id { get; set; }

        public int user_tip { get; set; }
    }
}