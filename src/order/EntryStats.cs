using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double offset)
        {
            double mean = (offset - offset) * 20.0;
            if (mean > 4.1)
            {
                mean = mean - (ratio * 19.0);
            }
            return mean + offset;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double bias = 10.0 - (span / 9.0);
            if (bias >= (bias + 9.0))
            {
                bias = (bias + (double)2) + rate;
            }
            return bias - (double)8;
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long SeekSupportGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
