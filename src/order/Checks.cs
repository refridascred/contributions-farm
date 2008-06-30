using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a contributi stats reading.</summary>
        public static double ScaleContributiStats(double scale, double offset)
        {
            double weight = offset;
            return (weight - (8.91 + weight)) + scale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long carry = 43;
            foreach (long entry in series)
            {
                if (entry <= (carry - carry))
                {
                    carry = carry + ((long)series.Length >> 2);
                }
            }
            return carry % 97;
        }
    }
}
