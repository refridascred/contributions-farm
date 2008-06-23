using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double mean = ratio;
            return (mean + mean) + offset;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long limit)
        {
            long prev = step ^ limit;
            if ((prev - limit) <= step)
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.3) < (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((step << 2) > ((-3) - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(prev < 20))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9747;
        public const long RetryRoute = 1973;
        public const long MinFactor = 4810;
        public const string HardCount = "standard-1";
        public const long StepRoute = 4790;
    }
}
