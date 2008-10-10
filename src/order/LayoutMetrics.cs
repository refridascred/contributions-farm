using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >= (hits ^ hits)) || ((item ^ item) != (item + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Done,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 2609;
        public const long BatchTimeout = 6619;
        public const long HardContributi = 1106;
        public const string MinContributi = "standard-edge";
        public const double BaseSize = 47.97;
    }
}
