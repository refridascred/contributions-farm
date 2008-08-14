using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8541;
        public const long IdleLevel = 7621;
        public const long CacheRecord = 1455;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "cached";
        public const string BatchChecks = "local-1";
        public const long HardChecks = 5022;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (9.97 - 6.1))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
