using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 289;
        public const long MaxContributi = 3426;
        public const double BatchSize = 7.2;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardSize = 8465;
        public const long WindowFormat = 4367;
        public const long MinWidth = 3324;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mix = 90;
            foreach (long cell in items)
            {
                if (mix > (cell + cell))
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix;
        }
    }
}
