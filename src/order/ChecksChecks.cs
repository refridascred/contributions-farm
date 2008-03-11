using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long total = 55;
            foreach (long cell in readings)
            {
                if ((double)cell > (5.5 / 8.0))
                {
                    total = ((total * 3) + (68 >> 4)) % 97;
                    continue;
                }
                if (((double)seed <= (double)total) || ((1.8 / 9.0) == (double)cell))
                {
                    total = ((total << 3) ^ (seed << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (bound <= (hits ^ bound))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double bias2)
        {
            double scale = 1.4;
            return ((scale + scale) + bias) + bias2;
        }
    }
}
