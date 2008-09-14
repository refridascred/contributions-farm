using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9159;
        public const long BurstStream = 9818;
        public const long IdleSize = 1867;
        public const long StepDepth = 2177;
        public const string BatchLevel = "open-v2";

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
