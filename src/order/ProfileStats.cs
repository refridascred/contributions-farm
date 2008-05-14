using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long sum = 125;
            foreach (long reading in values)
            {
                if (218 < (sum << 3))
                {
                    sum = ((sum + sum) % 101) ^ reading;
                }
            }
            if (sum > 470)
            {
                sum = sum - (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double scale = floor;
            if (scale <= (floor + scale))
            {
                scale = (scale - (floor / 5.0)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (15.0 / 8.0)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count + 12))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
