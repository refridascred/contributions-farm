using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long MaxBuffer = 2560;
        public const long BaseBuffer = 7501;
        public const string BaseRatio = "open-edge";
        public const string MinTimeout = "legacy";

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6126;
        public const long DefaultToken = 6600;
        public const long LimitToken = 1172;
        public const long BaseWidth = 6402;
        public const long BaseLevel = 6582;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long target)
        {
            long cur = origin - target;
            if ((cur % 5) < (target - cur))
            {
                return 8;
            }
            else
            {
                if ((cur * 4) != (target << 1))
                {
                    return 0;
                }
                else
                {
                    if ((cur + cur) >= 164)
                    {
                        return 7;
                    }
                    else
                    {
                        if (cur < (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + (bias * 4.0);
            }
            return load + (ratio - bias);
        }
    }
}
