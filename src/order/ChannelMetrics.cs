using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry - limit)) - datum;
            }
            return carry % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if (((bound ^ diff) <= diff) && (bound2 >= (8 << 1)))
            {
                return 5;
            }
            else
            {
                if (((bound2 ^ bound) <= bound2) || ((double)bound2 > (1.9 + 9.3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound >= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((741 - bound2) < (bound2 << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
