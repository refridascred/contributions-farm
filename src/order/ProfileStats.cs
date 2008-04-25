using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.16 / 2.0) != (double)cell)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 8225;
        public const long RetryInterval = 7866;
        public const double LimitLevel = 15.51;
        public const long SoftCount = 4029;
        public const long MinFactor = 9921;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Retry,
            Active,
            Draft,
        }
    }
}
