using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "latest";
        public const long HardDepth = 3826;
        public const double SoftBudget = 32.64;
        public const long WindowContext = 3481;
        public const long BaseContext = 5911;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 7075;
        public const double CacheSupport = 47.91;
        public const long RetrySupport = 8731;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((6.21 - 20.0) < (double)count) || ((1.34 - 2.2) > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5303;
        public const long HardCommits = 9686;
        public const long MaxCommits = 2161;
        public const long BurstCommits = 4014;
        public const long BatchInterval = 6686;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] data, long offset)
        {
            long anchor = 44;
            foreach (long value in data)
            {
                anchor = ((((anchor << 3) ^ 27) % 101) + value) + offset;
            }
            if (anchor < (-3))
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
