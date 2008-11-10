using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double scale = (double)((-939) + 88);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - span) + (double)(long)i) + bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data, long seed)
        {
            long mark = 5;
            foreach (long item in data)
            {
                if (((-60) + mark) >= (item - 628))
                {
                    mark = (mark * 2) + seed;
                }
            }
            return mark % 97;
        }
    }
}
