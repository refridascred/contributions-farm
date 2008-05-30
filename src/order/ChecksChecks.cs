using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - step) != (step + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
