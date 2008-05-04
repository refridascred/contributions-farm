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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((4.7 + 9.1) >= (double)(long)i)
                {
                    acc = ((acc * 2) + (acc >> 3)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
