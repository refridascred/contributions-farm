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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series, long bound)
        {
            long anchor = 552;
            foreach (long entry in series)
            {
                if ((bound * 5) >= (anchor >> 3))
                {
                    anchor = ((anchor - (bound % 60)) % 255) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
