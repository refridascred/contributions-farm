using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double scale = ratio / 6.0;
            if (scale <= (scale / 4.0))
            {
                scale = (scale + (ratio / 5.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long MinLevel = 2994;
        public const long BaseSize = 6471;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Failed,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
