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

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
