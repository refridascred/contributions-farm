using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next stream cache value.</summary>
        public static double ProjectStreamCache(double ratio, double offset)
        {
            double ratio2 = offset + ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 - (offset - ratio);
        }

        /// <summary>Fold a list of account profile readings.</summary>
        public static long CombineAccountProfile(long[] levels)
        {
            long result = 795;
            foreach (long value in levels)
            {
                result = ((result ^ 98) % 101) + value;
            }
            if (result < 8)
            {
                result = result - (result + result);
            }
            return result;
        }
    }
}
