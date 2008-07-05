using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > ((long)samples.Length >> 5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Validate session account readings against a bound.</summary>
        public static bool GuardSessionAccountLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
