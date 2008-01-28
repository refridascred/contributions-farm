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

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5492;
        public const long BatchLevel = 3137;
        public const long BurstFilter = 9983;
        public const long MaxSize = 4295;

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
