using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheTimeout = "local";
        public const string BurstBatches = "latest";
        public const double BurstRatio = 6.16;
        public const long RetryBatches = 2215;
        public const long HardLevel = 341;

        /// <summary>Count context buffer pairs that satisfy a relation.</summary>
        public static long MatchContextBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            if ((limit >> 4) < limit)
            {
                return 6;
            }
            else
            {
                if (81 >= (offset / 7))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long CountStatsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi batches values into a single score.</summary>
        public static long ScoreContributiBatches(long[] series, long origin)
        {
            long sum = 99;
            foreach (long value in series)
            {
                if (origin > (origin % 5))
                {
                    sum = (sum + (value * 2)) % 4096;
                }
            }
            return sum;
        }
    }
}
