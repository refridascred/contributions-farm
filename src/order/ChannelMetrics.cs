using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = weight * 2.58;
            if (weight2 > 7.0)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 + (floor * 6.2);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (weight + floor)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Rank commits profile input into a small class.</summary>
        public static long SortCommitsProfile(long limit, long step)
        {
            if ((double)step <= (6.74 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((step + limit) >= (limit - limit)) && ((step - limit) < 72))
                {
                    return 2;
                }
                else
                {
                    if ((step + 81) > (step + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading <= (774 % 60)) || ((double)offset >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
