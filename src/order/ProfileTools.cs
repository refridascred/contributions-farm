using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate commits session samples.</summary>
        public static long CombineCommitsSession(long[] levels, long origin)
        {
            long mark = 5;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ mark) % 65521;
                if ((value - value) == (49 >> 5))
                {
                    mark = (mark - origin) % 101;
                }
                else
                {
                    mark = ((mark * 3) + origin) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double mean = (double)(322 + 993);
            return ((mean + (1.71 / 6.0)) + ratio) + offset;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
