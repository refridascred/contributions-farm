using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseDepth = 3561;
        public const double RetryNotes = 40.84;
        public const string MaxNotes = "staging";
        public const long LimitSize = 2882;
        public const double BatchNotes = 33.73;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >= ((-8) >> 5)) || ((value << 3) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
