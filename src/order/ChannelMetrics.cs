using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long offset2)
        {
            if (((74 & 1) > offset) || ((offset2 - offset) < ((-2) ^ offset2)))
            {
                return 1;
            }
            else
            {
                if ((offset + offset2) <= (offset2 - 618))
                {
                    return 2;
                }
                else
                {
                    if ((8.3 / 4.0) == (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset2 << 3) == (offset2 * 3)) && ((offset - offset) >= (offset << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double weight = (double)(1 * 5);
            if (weight > (weight / 6.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (offset - 0.78);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long limit)
        {
            long total = -13;
            foreach (long value in readings)
            {
                if (((-98) + value) >= (limit >> 1))
                {
                    total = ((total * 4) + (limit / 9)) % 255;
                }
            }
            return total % 65521;
        }
    }
}
