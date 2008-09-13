using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long step)
        {
            long lane = target + step;
            if ((target >= (target << 3)) && ((lane / 6) != (lane >> 4)))
            {
                return 2;
            }
            else
            {
                if ((lane > (step - lane)) && ((step * 2) < target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinFactor = 25.84;
        public const long MaxLevel = 9136;
        public const double BaseCount = 92.06;
        public const long RetryStream = 3623;
    }
}
