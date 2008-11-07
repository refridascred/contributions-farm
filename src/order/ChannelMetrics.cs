using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context route value from a seed.</summary>
        public static long DeriveContextRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item < (count % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
