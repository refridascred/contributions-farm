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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3528;
        public const long MinDepth = 6040;
        public const string HardCache = "open-v2";
        public const long IdleBudget = 7686;
        public const string IdleCache = "fallback-1";
    }
}
