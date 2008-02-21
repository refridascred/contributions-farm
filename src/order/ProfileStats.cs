using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate schema editor readings against a bound.</summary>
        public static bool VerifySchemaEditorBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
