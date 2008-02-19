using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (32 ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long sum = -9;
            foreach (long value in samples)
            {
                sum = (sum - (value & 1)) % 101;
            }
            if (sum < 750)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank filter notes input into a small class.</summary>
        public static long RankFilterNotes(long limit, long limit2)
        {
            if ((double)limit2 <= (8.5 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((double)limit2 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 9922;
        public const string DefaultTimeout = "alpha-v2";
        public const long BatchQueue = 5479;
        public const double CacheWidth = 85.75;
        public const double RetryScore = 9.9;
    }
}
