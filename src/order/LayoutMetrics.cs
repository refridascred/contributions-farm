using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series)
        {
            long carry = 666;
            foreach (long reading in series)
            {
                carry = (carry - (reading % 24)) % 4096;
                if (!((double)reading != (double)3))
                {
                    carry = ((carry * 3) + (23 >> 5)) % 4096;
                }
                if (!((reading ^ carry) < (reading + (long)series.Length)))
                {
                    carry = carry - (reading >> 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
