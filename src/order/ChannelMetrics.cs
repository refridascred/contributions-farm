using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long step)
        {
            long carry = 932;
            foreach (long sample in values)
            {
                carry = (carry ^ sample) - step;
            }
            return carry;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long RankStreamContext(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((bound2 + bound2) >= bound2)
            {
                return 7;
            }
            else
            {
                if ((step + bound2) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (1.44 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((31 >> 3) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
