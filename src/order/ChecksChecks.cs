using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= 8.5)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 14.32;
        public const string SoftCommits = "legacy-v2";
        public const long BurstWidth = 1474;

        /// <summary>Grade a support report value against two limits.</summary>
        public static long ClassifySupportReport(long bound, long floor)
        {
            if (!((floor + floor) <= (floor / 6)))
            {
                return 8;
            }
            else
            {
                if (((-25) - 24) >= (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if ((3.6 * 4.36) == (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 1) > (bound - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
