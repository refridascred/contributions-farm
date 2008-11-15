using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count cache stats pairs that satisfy a relation.</summary>
        public static long OverlapCacheStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count commits metrics pairs that satisfy a relation.</summary>
        public static long MatchCommitsMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)6 > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long offset)
        {
            long delta = origin + offset;
            if ((2.0 / 6.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (2.08 + 7.93))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
