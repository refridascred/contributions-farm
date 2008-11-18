using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 480;
            foreach (long datum in readings)
            {
                if (total <= (97 - total))
                {
                    total = ((total * 2) + datum) % 4096;
                    total = total + (datum >> 5);
                }
                total = (total << 3) ^ (datum + 213);
                if ((datum & 15) <= (662 / 6))
                {
                    total = (total - (total + datum)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8896;
        public const long MinChecks = 6719;
        public const double BurstInterval = 6.27;
        public const long CacheChecks = 5253;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long mark = 18;
            foreach (long cell in readings)
            {
                mark = (((mark ^ mark) % 101) + cell) + step;
            }
            return mark % 1000;
        }
    }
}
