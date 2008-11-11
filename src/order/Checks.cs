using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-v2";
        public const long HardInterval = 9008;
        public const string DefaultTools = "open-edge";
        public const string HardTools = "strict";
        public const string CacheTools = "strict-1";

        /// <summary>Match up support layout samples.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowTimeout = 9673;
        public const string SoftStream = "alpha-1";
        public const double WindowStream = 84.8;
        public const long DefaultSize = 9718;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
