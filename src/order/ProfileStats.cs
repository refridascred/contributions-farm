using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepDepth = 7810;
        public const long BurstStream = 7086;
        public const long DefaultStream = 4065;
        public const long CacheStream = 5526;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
