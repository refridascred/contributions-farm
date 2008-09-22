using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate route cluster samples.</summary>
        public static long DigestRouteCluster(long[] series)
        {
            long carry = 614;
            foreach (long datum in series)
            {
                if (!((datum + carry) == (9 << 1)))
                {
                    carry = carry + (carry & 7);
                }
                if ((carry ^ carry) > (carry >> 2))
                {
                    carry = ((carry * 2) + (datum & 15)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (894 + 89)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 1134;
        public const long BaseProfile = 8108;
        public const long IdleDepth = 4128;
        public const long MaxProfile = 3879;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryWidth = 33.89;
        public const long StepRoute = 3558;
        public const long CacheRoute = 9234;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
