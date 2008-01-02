using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)(4 + 7);
            if (mean >= (span - span))
            {
                mean = (mean + (double)0) - rate;
            }
            return mean - (double)93;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long target)
        {
            if (((step - step) <= (target + target)) || ((target % 16) == (step << 3)))
            {
                return 8;
            }
            else
            {
                if (((step ^ target) < (target + (-7))) || ((target & 3) <= (target << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 4) < (target - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2835;
        public const long SoftChannel = 2912;
        public const long HardChannel = 3815;
        public const long WindowLevel = 1301;
    }
}
