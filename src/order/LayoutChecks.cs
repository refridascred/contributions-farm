using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double gain = 6.7 + scale;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (offset - 7.0)) - (double)(long)i;
            }
            return gain + (gain + gain);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long bound)
        {
            if (((285 & 7) >= (target + target)) || (5 < (target + bound)))
            {
                return 4;
            }
            else
            {
                if (!(bound < 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 998;
            foreach (long item in readings)
            {
                if ((double)mix > (4.6 + 14.0))
                {
                    mix = ((mix * 2) + (751 % 12)) + item;
                }
            }
            if (mix > 845)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 8603;
        public const double DefaultRoute = 44.0;
        public const double MinRoute = 6.37;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
