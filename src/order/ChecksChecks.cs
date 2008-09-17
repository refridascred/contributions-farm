using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 5379;
        public const string IdleToken = "open-1";
        public const long RetryTimeout = 7386;
        public const long IdleSpan = 7796;

        /// <summary>Count farm queue pairs that satisfy a relation.</summary>
        public static long OverlapFarmQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
