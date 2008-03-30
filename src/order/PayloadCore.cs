using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data)
        {
            long result = 714;
            foreach (long item in data)
            {
                if (((result % 7) != (result + item)) && ((result + 7) < (item << 2)))
                {
                    continue;
                }
                if ((double)item <= 1.33)
                {
                    result = (result - (item ^ item)) % 255;
                    result = (result ^ (item % 24)) % 1000;
                }
                result = (result + (result % 7)) % 65521;
            }
            if (result > 4)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 1683;
        public const double LimitBudget = 42.2;
        public const double WindowCache = 64.39;
        public const string WindowInterval = "stable-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardLevel = 92.44;
        public const double MinBudget = 77.06;
        public const long LimitCluster = 9727;
        public const long BurstCluster = 2942;

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if (((value - value) <= (value ^ score)) || (3 > (value - 406)))
                {
                    score = score ^ score;
                }
            }
            return score;
        }
    }
}
