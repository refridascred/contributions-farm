using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((-456) / 7) >= anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor ^ (floor + 2)) % 255;
                }
                anchor = anchor ^ (2 << 1);
                anchor = (anchor - (8 * 5)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 2912;
        public const string BaseQueue = "standard";
        public const long RetryInterval = 7163;
        public const long DefaultQueue = 4794;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 69.84;
        public const string HardWidth = "alpha";
        public const long MaxInterval = 8972;
        public const double SoftNotes = 75.88;
    }
}
