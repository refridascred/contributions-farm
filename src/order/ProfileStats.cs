using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((seed * 2) < seed) || ((double)tally <= 1.0)))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long TallyWindowTokenMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (105 <= (count ^ entry))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
