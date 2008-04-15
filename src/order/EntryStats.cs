using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long target)
        {
            long anchor = 89;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 4) + (target << 3)) + cell;
            }
            return anchor;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double gain = bias;
            if (gain > (gain + bias2))
            {
                gain = gain - bias2;
            }
            else
            {
                gain = gain - (double)37;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (3.2 - bias2)) - (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools metric reading by value.</summary>
        public static long LookupToolsMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
