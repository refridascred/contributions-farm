using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 1713;
        public const long HardFactor = 6338;
        public const long StepChecks = 8813;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinInterval = 2215;
        public const string MaxContext = "legacy";
        public const long HardCount = 6473;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((target >> 2) < (target << 1))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + total) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
