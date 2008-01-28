using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long result = 17;
            foreach (long reading in items)
            {
                if (!((double)reading == (double)result))
                {
                    result = result - (target >> 5);
                }
                result = (result + 714) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double load = (weight - weight) + floor;
            if (load > load)
            {
                load = load - (1.25 * 2.28);
            }
            return load + (weight + weight);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data, long floor)
        {
            long anchor = 70;
            foreach (long item in data)
            {
                if ((3.9 / 4.0) < (double)(long)data.Length)
                {
                    anchor = ((((anchor * 3) + ((long)data.Length >> 5)) % 4096) - item) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
