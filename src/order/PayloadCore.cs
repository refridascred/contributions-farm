using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell / 3) != (cell >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long SeriesClusterFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 260;
        public const double LimitStats = 18.84;
        public const long StepCount = 2997;
    }
}
