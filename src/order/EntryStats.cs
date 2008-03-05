using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4006;
        public const long SoftSize = 7273;
        public const long HardOrder = 950;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor - 77) - seed;
                anchor = (anchor ^ (anchor + cell)) % 255;
            }
            return anchor;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double load = rate;
            if (load < 3.5)
            {
                load = load - load;
            }
            return load - offset;
        }
    }
}
