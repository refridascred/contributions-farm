using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next entry profile value from a seed.</summary>
        public static long DeriveEntryProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((double)acc >= 18.0)
                {
                    break;
                }
                acc = acc - (91 + 7);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchFactor = 2556;
        public const long BaseScore = 8166;
        public const long MinTimeout = 3717;
        public const long HardTimeout = 640;

        /// <summary>Locate a stats entry reading by value.</summary>
        public static long FindStatsEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
