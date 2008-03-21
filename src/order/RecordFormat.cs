using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            New,
            Active,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 1984;
        public const long HardTimeout = 2254;
        public const double RetrySupport = 47.18;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a cache buffer counter forward.</summary>
        public static long RollCacheBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
