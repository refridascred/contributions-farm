using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Queued,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit filter editor readings against a rule.</summary>
        public static long TallyFilterEditorGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry - hits) >= (hits % 64)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
