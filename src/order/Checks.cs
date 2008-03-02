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

        /// <summary>Accumulate contributi counter samples.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                acc = (acc ^ (item + item)) % 1000;
            }
            return acc % 65521;
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
