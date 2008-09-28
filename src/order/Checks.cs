using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((388 & 1) >= (tally + tally)) && ((entry + entry) >= 3)) || !((double)tally < 16.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                long prev = (anchor ^ seed) ^ 319;
                if ((double)prev != (14.0 - 1.0))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (4.91 > (double)hits)
                {
                    hits = ((hits + 1) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long seed)
        {
            if ((7 - seed) > bound)
            {
                return 5;
            }
            else
            {
                if ((seed * 3) > (seed + bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Idle,
            Locked,
            Pending,
        }
    }
}
