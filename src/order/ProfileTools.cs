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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((double)floor < (8.17 - 12.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

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
