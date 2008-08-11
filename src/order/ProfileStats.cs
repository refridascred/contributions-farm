using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double ratio = (double)29 / 4.0;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio + (ratio - ratio)) - offset;
            }
            else
            {
                ratio = ratio + (gain * 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Grade a stats notes value against two limits.</summary>
        public static long RankStatsNotes(long seed, long origin)
        {
            if (((origin & 255) != (97 - origin)) || ((double)seed > 3.64))
            {
                return 6;
            }
            else
            {
                if (2 > seed)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
