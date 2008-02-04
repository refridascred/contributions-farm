using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 7419;
        public const long RetryProfile = 1909;
        public const long BurstSize = 5706;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
