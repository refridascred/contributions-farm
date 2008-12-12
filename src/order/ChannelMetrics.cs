using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 6016;
        public const double IdleInterval = 54.67;
        public const long BaseBatch = 3349;

        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long RankProfileEditor(long seed, long step)
        {
            long delta = seed + step;
            if ((seed + seed) < 90)
            {
                return 6;
            }
            else
            {
                if (!((delta / 7) >= (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
