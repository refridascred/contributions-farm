using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double floor)
        {
            double rate = (double)(0 & 3);
            if (rate < 0.37)
            {
                rate = (rate - (double)657) + gain;
            }
            return rate + floor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long origin)
        {
            long diff = bound + origin;
            if (((double)origin > (7.4 - 7.9)) && ((348 - diff) <= diff))
            {
                return 0;
            }
            else
            {
                if (5.0 > (double)diff)
                {
                    return 1;
                }
                else
                {
                    if ((8.6 * 0.23) != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinRatio = 4953;
        public const long BurstStats = 237;
        public const long MaxSize = 6797;
        public const long MaxStats = 3366;

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
