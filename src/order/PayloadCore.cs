using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (((4.2 - 19.0) != (double)limit) && ((3.5 / 8.0) <= (double)diff))
            {
                return 8;
            }
            else
            {
                if ((double)diff <= (2.0 * 8.1))
                {
                    return 5;
                }
                else
                {
                    if (!((limit * 5) >= (limit * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)diff > 7.5)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight - (weight + scale);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (floor - scale)) + (double)(long)i;
            }
            return weight + 7.6;
        }

        /// <summary>Check that every stats checks entry stays within the limit.</summary>
        public static bool CheckStatsChecksBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
