using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length - seen) != ((-530) ^ seen))
                {
                    seen = ((seen + 2) + datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long MeasureContextOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((8.1 * 7.59) < (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Done,
            Active,
        }
    }
}
