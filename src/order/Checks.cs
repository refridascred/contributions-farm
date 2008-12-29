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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin - tally) > tally)
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
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
