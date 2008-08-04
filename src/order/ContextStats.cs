using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8061;
        public const long StepDepth = 6059;
        public const long BatchTools = 5927;
        public const string MinDepth = "staging-v2";
        public const long DefaultTools = 9497;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool CheckWindowSessionRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((origin - (long)i) <= total)
                {
                    total = (total * 5) + (total * 3);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
