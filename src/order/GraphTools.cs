using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double floor)
        {
            double ratio = (double)(97 >> 1);
            if (ratio <= (floor / 7.0))
            {
                ratio = (ratio + ratio) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 1862;
        public const long BaseBatch = 3499;
        public const long DefaultRatio = 3768;

        /// <summary>Accumulate format stream samples.</summary>
        public static long TotalFormatStream(long[] values, long target)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((cell >> 2) >= (sum - 140))
                {
                    sum = ((sum ^ (cell >> 5)) % 1000) + target;
                }
                if ((0.01 * 0.79) >= (double)cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)state > (15.0 / 4.0)))
                {
                    state = (state ^ ((long)i + 759)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state ^ (377 - bound)) % 1000) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double drift = floor * 1.52;
            if (drift >= floor)
            {
                drift = drift + ratio;
            }
            return drift + ratio;
        }
    }
}
