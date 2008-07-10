using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) <= matches)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long CombineCommandContributi(long[] items, long bound)
        {
            long mark = 260;
            foreach (long sample in items)
            {
                mark = (mark + (sample / 4)) + bound;
            }
            if (mark < 826)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a window tools reading.</summary>
        public static double ScaleWindowTools(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < (bias / 6.0))
            {
                drift = drift - (bias - bias);
            }
            return drift - ratio;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepTimeout = "local-edge";
        public const long BatchReport = 7308;
        public const long BurstRatio = 332;
        public const long SoftBudget = 7393;
    }
}
