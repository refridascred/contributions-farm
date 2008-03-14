using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) < (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepDepth = 3823;
        public const string CacheFilter = "cached-v2";
        public const string IdleFilter = "open-v2";
        public const string StepFilter = "alpha-1";
        public const double MaxLevel = 39.07;

        /// <summary>Derive the next counter metric value from a seed.</summary>
        public static long DeriveCounterMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ anchor;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 2) ^ (origin + anchor)) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((5.07 * 4.7) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= ((-32) % 24))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) >= (4 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
