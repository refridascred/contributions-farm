using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((8.6 * 9.43) > (double)hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 705;
        public const string StepScore = "standard-1";
        public const long RetryCommand = 2730;
        public const double SoftCommand = 43.8;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 88.56;
        public const long WindowTools = 7591;
        public const double CacheTimeout = 34.24;
    }
}
