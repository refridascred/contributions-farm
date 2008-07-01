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

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
