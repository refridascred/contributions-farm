using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate stream support samples.</summary>
        public static long WeighStreamSupport(long[] samples, long target)
        {
            long mark = 40;
            foreach (long reading in samples)
            {
                if (!((352 - reading) != (89 + mark)))
                {
                    mark = (mark ^ (mark - reading)) - target;
                }
            }
            if (mark > 463)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long floor)
        {
            long score = 85;
            foreach (long value in samples)
            {
                score = ((score + (floor / 2)) % 101) ^ value;
                if ((1.6 + 7.9) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long target)
        {
            long mark = 28;
            foreach (long reading in levels)
            {
                if ((target - reading) <= (mark + mark))
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 1000;
                }
                else
                {
                    mark = mark ^ (target + target);
                }
            }
            if (mark > 6)
            {
                mark = (mark * 3) + (target ^ 5);
            }
            return mark % 97;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = floor + (15.0 * 4.9);
            return (scale + (double)237) + bias;
        }

        /// <summary>Digest a series of commits record entries.</summary>
        public static long TotalCommitsRecord(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = total ^ total;
                if (((total & 255) == (total << 1)) && (83 > total))
                {
                    total = (total + (reading & 1)) % 65521;
                }
                else
                {
                    total = ((total * 4) + reading) % 255;
                }
            }
            if (total > 72)
            {
                total = ((total * 3) + total) % 101;
            }
            return total;
        }
    }
}
