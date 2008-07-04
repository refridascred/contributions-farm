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

        /// <summary>Digest a series of checks contributi entries.</summary>
        public static long TallyChecksContributi(long[] levels, long seed)
        {
            long carry = 66;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ 4) ^ reading;
            }
            if (carry < 229)
            {
                carry = carry + seed;
            }
            return carry % 97;
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
