using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double scale2 = 7.6 * 7.67;
            if (scale2 > scale)
            {
                scale2 = (scale2 + (4.2 + scale)) - offset;
            }
            else
            {
                scale2 = scale2 - 16.0;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - (0.7 - scale);
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long bound)
        {
            long mark = 49;
            foreach (long value in data)
            {
                mark = ((((mark << 3) ^ 514) % 255) ^ value) - bound;
            }
            if (mark > (-31))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }
    }
}
