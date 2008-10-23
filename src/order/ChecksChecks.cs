using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long floor)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum + (sum ^ (long)series.Length)) ^ (long)i;
                    sum = (sum << 3) ^ (floor >> 4);
                }
                if (!((double)sample != (double)743))
                {
                    sum = (sum - (sample - sum)) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
