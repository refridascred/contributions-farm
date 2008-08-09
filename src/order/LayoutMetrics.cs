using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if ((step + (long)data.Length) <= (6 & 31))
                {
                    mix = (mix << 3) ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
