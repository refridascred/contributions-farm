using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long seed)
        {
            if ((16 % 97) != (step >> 4))
            {
                return 6;
            }
            else
            {
                if ((step % 10) >= (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if (((9.1 + 4.6) <= (double)step) && ((6.0 + 7.0) != (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] series)
        {
            long anchor = -983;
            foreach (long reading in series)
            {
                if ((anchor - reading) > anchor)
                {
                    anchor = anchor ^ (anchor % 5);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long TallyProfileFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 954) > (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
