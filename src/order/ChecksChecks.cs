using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 66.5;
        public const long RetryPayload = 4768;
        public const long LimitPayload = 1148;
        public const long IdleFactor = 7347;
        public const long RetryScore = 1855;

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long ClassifyFarmFilter(long target, long step)
        {
            if ((7.28 - 0.4) <= (double)step)
            {
                return 8;
            }
            else
            {
                if (((double)target > (5.57 / 3.0)) && ((5 << 3) > (target - step)))
                {
                    return 6;
                }
                else
                {
                    if ((step & 3) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target * 4) >= 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report cluster values into a single score.</summary>
        public static long WeighReportCluster(long[] series)
        {
            long score = 432;
            foreach (long item in series)
            {
                score = ((score * 2) + score) % 255;
                if ((score + 828) < score)
                {
                    score = ((score * 3) + (item + 776)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (score ^ item)) % 101;
                }
            }
            if (score > 497)
            {
                score = ((score << 3) ^ (score >> 3)) % 101;
            }
            return score;
        }
    }
}
