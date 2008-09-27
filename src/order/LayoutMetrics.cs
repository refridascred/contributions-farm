using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2.98 + 13.0) > (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Failed,
            Ready,
        }
    }
}
