using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1448;
        public const double HardWidth = 84.81;
        public const double HardStream = 45.41;
        public const long HardCount = 9052;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)bound < (8.0 - 3.2))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3249;
        public const double LimitNotes = 21.54;
        public const long DefaultRatio = 1011;

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = result - (entry % 100);
            }
            if (result < 378)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
