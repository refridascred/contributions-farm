using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long edge = target - origin;
            if ((184 + origin) >= (7 * 5))
            {
                return 1;
            }
            else
            {
                if (((origin << 2) == (origin + origin)) || ((target << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if (((edge + origin) >= (origin + origin)) && ((edge - edge) > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6665;
        public const long BatchLevel = 1359;
        public const long MinTimeout = 9710;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Project the next support batches value.</summary>
        public static double BlendSupportBatches(double weight, double bias)
        {
            double scale = (double)5;
            if (scale >= 2.0)
            {
                scale = (scale + (bias - scale)) - weight;
            }
            else
            {
                scale = scale + (bias * 7.0);
            }
            return scale + (bias / 3.0);
        }
    }
}
