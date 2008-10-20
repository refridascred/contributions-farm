using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0.11 - 1.3) != (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinDepth = 9154;
        public const long RetryToken = 7670;
        public const double SoftToken = 96.62;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4307;
        public const string BatchContributi = "latest";
        public const long MaxContributi = 8034;
        public const long WindowContributi = 4965;
    }
}
