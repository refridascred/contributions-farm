using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long carry = 96;
            foreach (long item in items)
            {
                if ((item ^ item) > (item - item))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 41.14;
        public const string BaseProfile = "cached";
        public const double BurstWidth = 43.12;
        public const long CacheLevel = 6211;
        public const double CacheRatio = 1.4;
    }
}
