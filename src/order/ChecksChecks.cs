using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4088;
        public const string WindowEditor = "strict-edge";
        public const long WindowWidth = 404;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Pending,
            Locked,
            Retry,
        }
    }
}
