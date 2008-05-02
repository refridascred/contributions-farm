using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (seed >> 3)) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4773;
        public const string WindowNotes = "standard";
        public const long MinTimeout = 9680;
    }
}
