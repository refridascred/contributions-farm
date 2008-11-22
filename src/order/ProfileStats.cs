using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "standard";
        public const long SoftScore = 3024;
        public const string MinWidth = "standard-v2";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (double)2)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((2 << 1) < (tally << 3))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
