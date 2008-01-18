using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value ^ (long)samples.Length) > (value * 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long carry = 367;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                }
                if ((item ^ item) != (235 + item))
                {
                    carry = (carry + (carry ^ item)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
