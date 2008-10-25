using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph cache figure with a bias.</summary>
        public static double AdjustGraphCache(double ratio, double bias)
        {
            double scale = ratio - (double)369;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio + 8.62)) - (double)(long)i) + bias;
            }
            return scale - ratio;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                if ((anchor + datum) <= anchor)
                {
                    anchor = (anchor * 4) + (anchor >> 5);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor - (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }
    }
}
