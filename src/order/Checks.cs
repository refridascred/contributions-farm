using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8811;
        public const long StepInterval = 6756;
        public const long MaxSupport = 4583;
        public const double HardSupport = 37.9;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long StepLayoutSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((bound * 4) == (carry * 2)))
                {
                    continue;
                }
                carry = (carry * 5) + (bound & 15);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Synced,
            Locked,
        }
    }
}
