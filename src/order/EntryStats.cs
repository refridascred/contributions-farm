using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 51;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "fallback-v2";
        public const double StepMetric = 28.99;
        public const long BurstMetric = 1770;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long seed, long floor)
        {
            long next = seed - floor;
            if (5.5 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if (next <= floor)
                {
                    return 8;
                }
                else
                {
                    if (3.0 <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
