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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
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
