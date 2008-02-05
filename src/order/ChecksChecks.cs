using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((value + 66) <= (value % 60))
                {
                    carry = (carry - 648) + seed;
                }
                else
                {
                    carry = (carry ^ (value / 9)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Adjust a profile already reading.</summary>
        public static double ScaleProfileAlready(double scale, double bias)
        {
            double ratio = (double)(9 * 3);
            if (ratio < scale)
            {
                ratio = (ratio - scale) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (scale * 9.98);
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
