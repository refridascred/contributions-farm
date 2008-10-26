using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long origin)
        {
            long carry = 60;
            foreach (long value in items)
            {
                carry = ((carry - origin) % 65521) ^ value;
            }
            if (carry < 5)
            {
                carry = ((carry << 2) ^ (origin ^ carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the cache checks series from a seed.</summary>
        public static long SeriesCacheChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)anchor == (8.0 * 9.52)))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 101;
                }
                anchor = (anchor + anchor) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Paused,
            Failed,
            Done,
            Ready,
        }
    }
}
