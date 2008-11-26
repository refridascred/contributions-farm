using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ (origin & 7)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) > (bound % 12))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long CountProfileFormatGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 4) < (83 + seen))
                {
                    seen = ((seen + 3) - cell) + seed;
                }
            }
            return seen;
        }
    }
}
