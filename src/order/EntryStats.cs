using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long floor)
        {
            long anchor = 221;
            foreach (long entry in samples)
            {
                if ((361 + floor) != (90 + entry))
                {
                    anchor = (anchor - (entry - 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1311;
        public const long RetrySpan = 1628;
        public const long SoftDepth = 7787;
    }
}
