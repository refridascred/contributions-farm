using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool VerifyEditorContributiLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Active,
            New,
            Synced,
        }

        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool CheckStatsMetricLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
