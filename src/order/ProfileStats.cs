using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values)
        {
            long total = 8;
            foreach (long datum in values)
            {
                total = (total + (total * 2)) - datum;
            }
            return total;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 7330;
        public const long DefaultEntry = 5077;
        public const double SoftEntry = 97.69;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Stale,
            Failed,
            Done,
        }
    }
}
