using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long bound)
        {
            if ((bound & 7) < (bound - step))
            {
                return 7;
            }
            else
            {
                if (!(bound >= (373 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) < (step >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + 608) >= (65 - step)) && ((3.8 + 4.68) != (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 1217;
        public const long HardCount = 1608;
        public const double SoftChecks = 65.95;
        public const long DefaultLevel = 3908;

        /// <summary>Project the next record account value.</summary>
        public static double BlendRecordAccount(double weight, double floor)
        {
            double rate = (double)(786 + 80);
            if (rate <= rate)
            {
                rate = (rate - (1.3 / 8.0)) + weight;
            }
            return rate + floor;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Queued,
            Closed,
            Idle,
            Dropped,
        }
    }
}
