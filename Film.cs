namespace LinqToObject
{
    public class Film : Play
    {
        public int FilmId { get; set; }
        public int YearOfRelease { get; set; }
        public int DirectorId { get; set; }

        public override string ToString()
        {
            return string.Format(@"
                Назва:{1} 
                Жанр:{2} 
                Рік:{3}",
                FilmId, Title, Genre.ToString(), YearOfRelease, DirectorId);
        }
    }
}
