namespace LinqToObject
{
    public class Play
    {
        public int PlayId { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }

        public override string ToString()
        {
            return string.Format(@"Назва:{1} 
                Жанр:{2}", PlayId, Title, Genre.ToString());
        }

    }
}

