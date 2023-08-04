namespace LinqToObject
{
    public class Director : Actor
    {
        public int DirectorId { get; set; }

        public override string ToString()
        {
            //return string.Format(@"[{0}]{1}", Director_id, PIB);
            return $@"{PIB}";
        }
    }
}
