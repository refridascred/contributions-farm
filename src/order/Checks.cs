using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "open-v2";
        public const long LimitRatio = 7590;
        public const long LimitWidth = 4127;
        public const long MaxStream = 3044;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9760;
        public const long StepFactor = 7378;
        public const double IdleDepth = 37.12;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long offset, long seed)
        {
            if ((13.0 - 5.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (!((5.2 + 5.41) != (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset < (seed << 1)) || (7 < (seed / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
