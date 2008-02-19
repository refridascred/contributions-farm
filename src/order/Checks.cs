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

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] items)
        {
            long anchor = -7;
            foreach (long value in items)
            {
                anchor = ((anchor - (anchor & 7)) % 4096) ^ value;
            }
            if (anchor < 3)
            {
                anchor = (anchor - 62) % 65521;
            }
            return anchor % 1000;
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (step & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 9922;
        public const string DefaultTimeout = "alpha-v2";
        public const long BatchQueue = 5479;
        public const double CacheWidth = 85.75;
        public const double RetryScore = 9.9;
    }
}
