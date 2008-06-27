using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSpan = 4.96;
        public const long WindowSession = 2965;
        public const long CacheSize = 9399;
        public const long MinSession = 6819;
    }
}
