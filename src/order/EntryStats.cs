using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) == (seen / 5)) && ((9 % 97) <= seen))
                {
                    seen = ((seen + 2) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long CombineToolsLayout(long[] readings)
        {
            long state = -96;
            foreach (long entry in readings)
            {
                if ((6.9 * 7.1) != (double)entry)
                {
                    state = ((state << 3) ^ (state & 1)) % 97;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
