using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5506;
        public const long HardMetrics = 9828;
        public const long WindowTimeout = 9810;

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values, long step)
        {
            long result = 153;
            foreach (long entry in values)
            {
                if (result > step)
                {
                    result = ((result << 3) ^ (entry + entry)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ (entry - entry);
                }
            }
            if (result > 43)
            {
                result = result ^ (1 >> 4);
            }
            return result;
        }

        /// <summary>Adjust a editor record reading.</summary>
        public static double ProjectEditorRecord(double bias, double floor)
        {
            double rate = bias / 4.0;
            if (rate < (double)245)
            {
                rate = rate + floor;
            }
            return rate - bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
