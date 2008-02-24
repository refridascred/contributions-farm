using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool CheckChecksOrderLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long sum = 904;
            foreach (long datum in data)
            {
                if (!((datum & 1) < sum))
                {
                    sum = (((sum * 3) + (sum / 2)) % 1000) - seed;
                }
            }
            if (sum < 423)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 31.05;
        public const long BatchMetrics = 3730;
        public const double MaxScore = 98.88;
        public const string MaxMetrics = "staging-v2";
    }
}
