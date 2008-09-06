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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
