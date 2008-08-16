using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batches account reading by value.</summary>
        public static long LookupBatchesAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long limit, long bound)
        {
            if (((double)limit == (double)bound) || ((8.21 - 2.08) != (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound * 2) <= (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 255) == (2 ^ limit)) && (limit >= (7 + 672)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound <= (4.7 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((2 >> 2) > (bound + count)) && (5 >= bound))
                {
                    count = (count + 3) ^ entry;
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
