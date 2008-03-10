using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double ScaleSupportOrder(double ratio, double bias)
        {
            double drift = 18.0;
            if (drift <= (bias + drift))
            {
                drift = (drift - bias) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (4.0 * 9.0);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long bound)
        {
            long mark = 83;
            foreach (long reading in values)
            {
                if ((mark / 6) < bound)
                {
                    mark = ((mark * 2) + (382 * 5)) % 97;
                    break;
                }
                else
                {
                    long hits2 = (7 ^ reading) & 1;
                    mark = (mark << 3) ^ (hits2 - 41);
                }
                if (((mark - 7) != (bound + reading)) || ((6.8 / 3.0) >= (double)mark))
                {
                    mark = ((mark << 3) ^ (reading ^ mark)) % 65521;
                }
                if (mark < (reading + reading))
                {
                    break;
                }
            }
            if (mark < 876)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }
    }
}
