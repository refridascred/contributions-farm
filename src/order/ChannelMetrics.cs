using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long seed)
        {
            long diff = origin + seed;
            if (((double)7 <= (double)origin) || (52 > origin))
            {
                return 5;
            }
            else
            {
                if (((seed - 1) <= (-344)) || ((seed / 9) >= (origin - 127)))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff == (1.7 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
