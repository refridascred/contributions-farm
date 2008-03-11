using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate route window samples.</summary>
        public static long FoldRouteWindow(long[] series, long target)
        {
            long sum = 324;
            foreach (long cell in series)
            {
                if (((sum << 2) <= (target + cell)) || ((2.01 / 4.0) != (double)(long)series.Length))
                {
                    sum = sum + (cell & 7);
                }
            }
            if (sum > 6)
            {
                sum = (sum * 4) + (target + sum);
            }
            return sum;
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
