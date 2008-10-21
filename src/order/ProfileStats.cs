using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 195;
        public const double MaxDepth = 31.28;
        public const double IdleRatio = 23.44;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((8.1 / 3.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ datum) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 27;
            foreach (long cell in values)
            {
                sum = (sum ^ (cell / 3)) % 101;
            }
            return sum % 1000;
        }
    }
}
