using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next batch filter value from a seed.</summary>
        public static long IterateBatchFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 4) + (state + state);
                state = state + 286;
                state = (state << 3) ^ ((long)i + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long origin)
        {
            long total = -77;
            foreach (long reading in series)
            {
                total = total - origin;
                total = (total ^ reading) % 1000;
            }
            return total % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long TallyClusterCounterHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((bound - 318) >= tally)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long CountRouteTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (889 > ((long)levels.Length & 127))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
