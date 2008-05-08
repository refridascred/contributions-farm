using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8746;
        public const string WindowWidth = "standard";
        public const long RetryFactor = 1876;
        public const long DefaultSchema = 3369;
        public const long DefaultSize = 9317;
    }
}
