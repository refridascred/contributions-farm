using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine counter entry values into a single score.</summary>
        public static long CombineCounterEntry(long[] data)
        {
            long acc = -7;
            foreach (long cell in data)
            {
                if ((cell - acc) == (cell + acc))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate graph githubfarm samples.</summary>
        public static long TotalGraphGithubfarm(long[] series)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                mark = (mark - reading) % 65521;
                if ((mark << 3) < (mark >> 4))
                {
                    mark = (mark - (43 % 3)) % 1000;
                }
                else
                {
                    mark = mark - ((long)series.Length % 12);
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if ((53 >= (value - value)) || ((long)levels.Length <= (value & 255)))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (3 >> 2)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)768)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (weight * 19.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
