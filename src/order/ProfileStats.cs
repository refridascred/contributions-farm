using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double ratio = (double)258 * 3.57;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio + bias)) + (double)(long)i) - offset;
            }
            return ratio - (7.9 * 5.24);
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
