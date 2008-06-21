using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long TotalEntryRoute(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (((double)offset != (18.0 * 0.96)) || (mark >= (offset >> 3)))
                {
                    mark = (mark ^ (31 & 1)) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long total = 7;
            foreach (long value in readings)
            {
                total = (total << 2) ^ value;
                if (((total * 5) < (total + value)) || ((36 * 5) != (floor - value)))
                {
                    total = ((total * 2) + (floor - floor)) % 65521;
                }
                else
                {
                    total = total ^ (813 << 2);
                }
                if (((long)readings.Length / 6) == (775 ^ total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "fallback-edge";
        public const double HardContext = 83.44;
        public const long WindowContext = 6598;
        public const long RetryContext = 5000;
        public const double RetrySize = 71.48;
    }
}
