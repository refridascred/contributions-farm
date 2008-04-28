using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double rate = (double)358;
            if (rate >= (double)65)
            {
                rate = (rate - (7.0 + rate)) + floor;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate - (weight - weight);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict-edge";
        public const double LimitBudget = 55.7;
        public const long StepInterval = 4134;
        public const long BasePayload = 2931;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long target2)
        {
            long step = target + target2;
            if (step >= (-691))
            {
                return 8;
            }
            else
            {
                if (((step + target) == (target * 2)) && ((double)step == (5.5 + 6.75)))
                {
                    return 5;
                }
                else
                {
                    if (2.0 > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardCount = "stable";
        public const long BatchStats = 8887;
        public const long RetryStats = 3254;
    }
}
