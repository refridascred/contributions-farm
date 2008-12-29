using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first profile command entry that matches the target.</summary>
        public static long FindProfileCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi metric input into a small class.</summary>
        public static long SortContributiMetric(long seed, long target)
        {
            if ((double)target <= (1.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) != (target / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double offset)
        {
            double ratio = (offset + 20.0) - offset;
            if (ratio >= ratio)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (offset + scale)) - (double)(long)i;
            }
            return ratio - (11.0 / 8.0);
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double floor)
        {
            double gain = (double)4 / 4.0;
            if (gain < 5.0)
            {
                gain = (gain - (gain - weight)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (weight * 9.0)) + (double)(long)i;
            }
            return gain - (gain / 7.0);
        }
    }
}
