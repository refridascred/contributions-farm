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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + limit) % 101;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
