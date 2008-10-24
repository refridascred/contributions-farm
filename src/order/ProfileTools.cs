using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context format input into a small class.</summary>
        public static long GradeContextFormat(long bound, long target)
        {
            if ((target / 2) >= 56)
            {
                return 3;
            }
            else
            {
                if ((bound ^ bound) > (8 % 100))
                {
                    return 4;
                }
                else
                {
                    if ((8.82 + 9.0) == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            New,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "stable-1";
        public const string CacheSchema = "open-edge";
        public const long WindowBudget = 6799;
    }
}
