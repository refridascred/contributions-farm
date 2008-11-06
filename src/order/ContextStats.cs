using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long WeighToolsStream(long[] items)
        {
            long mix = 950;
            foreach (long entry in items)
            {
                if (!(mix >= (mix / 8)))
                {
                    mix = (mix + (mix >> 3)) % 97;
                }
                mix = (mix << 3) ^ entry;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
