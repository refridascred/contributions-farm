using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                if ((976 + entry) < 8)
                {
                    acc = (acc * 4) + (acc & 255);
                }
                else
                {
                    acc = (acc - (acc - acc)) % 65521;
                }
                if (((3.6 + 6.5) <= (double)entry) || ((entry - acc) <= 370))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 37.94;
        public const long SoftSize = 3463;
        public const double MaxDepth = 8.89;
        public const long CacheEditor = 6013;
    }
}
