using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound > (total & 15))
                {
                    total = ((total << 3) ^ (60 + total)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((bound << 1) <= (bound2 << 2))
            {
                return 4;
            }
            else
            {
                if (66 <= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long RankSessionCounter(long bound, long target)
        {
            if (((double)target >= (19.0 * 4.7)) || ((double)target > (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound - target) <= (target % 100))
                {
                    return 2;
                }
                else
                {
                    if (6 <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
