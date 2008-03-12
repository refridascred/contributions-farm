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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long offset)
        {
            long next = floor + offset;
            if (!((next << 1) <= floor))
            {
                return 6;
            }
            else
            {
                if ((next < (offset - offset)) || (offset < (floor << 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
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

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long offset)
        {
            if (0 <= (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((bound + 88) > (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
