using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double bias = span / 5.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double ratio, double floor)
        {
            double scale = (double)(927 + 24);
            return ((scale - (scale / 2.0)) + ratio) + floor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if (((state + (long)items.Length) < state) || ((20.0 + 1.1) <= (double)entry))
                {
                    state = ((state * 4) + entry) % 101;
                }
            }
            return state;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (65 * 5)) % 1000;
                mark = ((mark << 2) ^ ((long)i * 5)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two metrics channel measurements.</summary>
        public static double ProjectMetricsChannel(double rate, double bias)
        {
            double weight = rate * 14.0;
            return (weight + weight) + bias;
        }
    }
}
