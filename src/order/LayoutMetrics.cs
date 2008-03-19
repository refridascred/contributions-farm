using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepFactor = "latest-edge";
        public const long DefaultCount = 1937;
        public const long DefaultBuffer = 6718;
        public const double MaxBuffer = 17.32;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long target2)
        {
            if ((target > (6 + 921)) || (target > (target + target)))
            {
                return 3;
            }
            else
            {
                if ((target + target2) < target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool VerifyClusterFarmBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
