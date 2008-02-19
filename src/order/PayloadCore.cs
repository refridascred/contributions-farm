using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2599;
        public const long LimitChecks = 3359;
        public const long IdleChecks = 3474;
        public const long DefaultChecks = 5122;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Synced,
            Done,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double scale = (bias2 - bias) + (5.9 + bias2);
            if (scale <= 7.4)
            {
                scale = scale + (bias + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 13.0) - (double)(long)i;
            }
            return scale - (double)5;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((1.49 + 3.56) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - limit2) < limit)
                {
                    return 3;
                }
                else
                {
                    if (84 > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 10) < (limit2 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
