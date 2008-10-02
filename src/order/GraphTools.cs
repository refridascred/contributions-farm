using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5214;
        public const double IdleAlready = 26.34;
        public const double MaxDepth = 8.4;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((offset & 7) > (item + (long)values.Length))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next record route value.</summary>
        public static double AdjustRecordRoute(double scale, double offset)
        {
            double mean = (double)(4 % 16);
            if (mean < offset)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale - scale)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value > (double)(long)data.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
