using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "alpha-edge";
        public const long DefaultTimeout = 3547;
        public const long BatchWidth = 690;
        public const double SoftBatch = 13.98;
        public const long MaxBatch = 3974;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long lane = limit - offset;
            if ((6.1 * 3.0) == (double)lane)
            {
                return 5;
            }
            else
            {
                if (lane <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) <= (lane ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
