using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9948;
        public const long BurstEditor = 9075;
        public const long CacheInterval = 5859;
        public const double CacheTimeout = 85.57;
        public const long WindowEditor = 2642;
    }
}
