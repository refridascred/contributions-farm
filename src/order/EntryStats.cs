using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next window format value from a seed.</summary>
        public static long RollWindowFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (sum >= target)
                {
                    sum = ((sum * 3) + (target << 3)) % 1000;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 3501;
        public const string MaxBatches = "stable-v2";
        public const long BurstSpan = 5261;
        public const long MinBatches = 462;
        public const double HardBatches = 24.32;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7237;
        public const long SoftTimeout = 5797;
        public const string SoftRatio = "local-edge";
        public const double IdleInterval = 37.99;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mark = 54;
            foreach (long sample in readings)
            {
                if ((sample + mark) > (mark * 4))
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark;
        }
    }
}
