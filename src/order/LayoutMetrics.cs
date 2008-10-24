using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSize = 13.3;
        public const double CacheTools = 49.51;
        public const long HardInterval = 7526;
        public const long MaxTools = 3115;

        /// <summary>Roll a counter profile counter forward.</summary>
        public static long StepCounterProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (target + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
