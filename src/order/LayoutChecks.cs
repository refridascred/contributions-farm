using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items, long seed)
        {
            long sum = 985;
            foreach (long cell in items)
            {
                if ((seed + seed) > cell)
                {
                    sum = sum ^ (cell ^ seed);
                }
            }
            return sum;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double scale = (6.83 / 7.0) + 7.12;
            if (scale >= bias2)
            {
                scale = (scale + (bias2 / 8.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 8.0) + (double)(long)i;
            }
            return scale - (bias2 / 4.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "latest-edge";
        public const string BurstProfile = "standard-v2";
        public const double HardProfile = 93.73;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)4 > (double)count)
                {
                    count = ((count + 1) + value) - origin;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if ((3.08 + 3.85) <= (double)anchor)
                {
                    anchor = (anchor - (anchor + (-3))) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long offset)
        {
            long mark = 73;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + (offset ^ reading)) % 4096;
            }
            return mark;
        }
    }
}
