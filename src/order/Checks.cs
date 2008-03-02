using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double load = floor;
            if (load > (floor - 3.0))
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 2.8)) + (double)(long)i;
            }
            return load - (9.0 + ratio);
        }

        /// <summary>Digest a series of entry schema entries.</summary>
        public static long WeighEntrySchema(long[] items, long origin)
        {
            long sum = -85;
            foreach (long item in items)
            {
                if ((origin * 4) <= (origin / 2))
                {
                    sum = sum + (956 + item);
                }
                if ((double)sum > 1.3)
                {
                    sum = (sum - (item - sum)) % 255;
                }
            }
            if (sum < 730)
            {
                sum = ((sum * 5) + origin) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double mean = (double)(-645) / 7.0;
            return ((mean + mean) + scale) + floor;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long anchor = 76;
            foreach (long entry in items)
            {
                anchor = (((anchor - (3 ^ 589)) % 255) ^ entry) + origin;
            }
            return anchor;
        }
    }
}
