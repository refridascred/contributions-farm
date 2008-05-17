using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double bias2 = bias * 18.0;
            if (bias2 >= (double)656)
            {
                bias2 = bias2 - (bias / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + weight;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)73 <= (double)step) && ((9.9 + 2.44) >= (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
