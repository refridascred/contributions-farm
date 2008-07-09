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

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double drift = span;
            if (drift <= ratio)
            {
                drift = drift + (span - span);
            }
            else
            {
                drift = drift + (drift / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (ratio + ratio);
        }

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
