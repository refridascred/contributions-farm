using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinDepth = 6781;
        public const long WindowWidth = 3409;
        public const double IdleDepth = 66.91;
        public const long MaxFactor = 4932;
        public const long RetryScore = 7173;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long bound)
        {
            if (step >= (bound + 5))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (6.6 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if (((step * 5) > step) && ((step - step) == (step / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (2.09 - 2.0))
                {
                    count = ((count + 2) ^ reading) - seed;
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
