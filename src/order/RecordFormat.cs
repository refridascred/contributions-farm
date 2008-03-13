using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = (double)(4 - 7);
            if (bias > (offset / 8.0))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (bias * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (2.0 / 6.0)) + (double)(long)i;
            }
            return bias - (rate * 1.1);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 876;
            foreach (long item in series)
            {
                total = ((total * 5) + (460 + item)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = (carry + (carry - carry)) ^ datum;
            }
            if (carry > 41)
            {
                carry = carry - (carry - carry);
            }
            return carry % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
