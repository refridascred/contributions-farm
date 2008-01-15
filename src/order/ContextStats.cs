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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Dropped,
            Pending,
            Idle,
            Failed,
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
