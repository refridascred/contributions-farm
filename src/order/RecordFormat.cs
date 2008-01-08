using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((origin * 2) > (11 / 7))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double weight = (double)8 + (offset / 7.0);
            if (weight > (scale / 4.0))
            {
                weight = weight - (scale - offset);
            }
            return weight + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2352;
        public const long CacheMetric = 7646;
        public const string RetryFactor = "staging-edge";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Paused,
            Idle,
            Synced,
            Done,
        }
    }
}
