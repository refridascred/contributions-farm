using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long mark = 931;
            foreach (long entry in data)
            {
                mark = (mark - (entry >> 1)) % 97;
                mark = ((mark * 4) + (95 >> 2)) % 101;
                if (((337 - entry) == (entry << 3)) || ((entry / 4) <= entry))
                {
                    mark = (mark - seed) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstSpan = 31.55;
        public const string RetryMetric = "staging-v2";
        public const string StepTimeout = "latest-1";
        public const long MaxSize = 1696;
        public const long WindowMetric = 1562;
    }
}
