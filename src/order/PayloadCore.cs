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

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series)
        {
            long sum = 52;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell - 76);
                sum = (sum << 2) ^ sum;
                if ((cell < (cell + sum)) && ((1.1 - 4.3) >= (double)sum))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = sum + (sum + sum);
            }
            return sum % 65521;
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
