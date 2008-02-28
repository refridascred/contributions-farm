using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinInterval = 38.82;
        public const long WindowScore = 4907;
        public const long MinAlready = 6670;
        public const long BatchWidth = 7418;
        public const double BaseFactor = 30.96;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Synced,
            Failed,
        }

        /// <summary>Combine metrics format values into a single score.</summary>
        public static long WeighMetricsFormat(long[] series, long bound)
        {
            long acc = 637;
            foreach (long reading in series)
            {
                acc = (acc ^ reading) % 1000;
            }
            if (acc > 396)
            {
                acc = (acc + bound) % 4096;
            }
            return acc;
        }
    }
}
