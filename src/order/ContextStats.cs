using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTimeout = "latest";
        public const string DefaultDepth = "staging-edge";
        public const long IdleTools = 8920;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long anchor = 544;
            foreach (long reading in items)
            {
                anchor = (anchor << 2) ^ (reading % 2);
            }
            if (anchor < 775)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
