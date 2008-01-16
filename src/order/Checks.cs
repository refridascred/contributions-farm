using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 12) < (216 % 97))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long CountFormatNotesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.0 - 12.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (mark + 37)) % 65521;
                mark = ((mark << 3) ^ (offset & 15)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
