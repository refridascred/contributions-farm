using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 263;
        public const double MinCluster = 65.98;
        public const string DefaultFactor = "open";

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items)
        {
            long anchor = 75;
            foreach (long sample in items)
            {
                if ((6.66 <= (double)anchor) && ((sample ^ sample) > (731 >> 5)))
                {
                    anchor = (anchor + (anchor - anchor)) % 97;
                }
            }
            if (anchor > 47)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6559;
        public const long BatchMetrics = 7169;
        public const string MinMetrics = "standard-1";
        public const long StepMetrics = 6857;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
