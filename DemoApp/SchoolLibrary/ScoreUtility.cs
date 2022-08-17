namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScorable BestScore(ICollection<IScorable> Assignments)
        {
            IScorable best = null;
            foreach (IScorable a in Assignments)
            {
                if (best == null || a.Score > best.Score)
                {
                    best = a;
                }
            }
            return best;
        }
    }
}
