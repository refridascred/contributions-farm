using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 6.22;
        public const string RetryTimeout = "latest-edge";
        public const long MaxFilter = 2378;
        public const double DefaultFilter = 34.6;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total ^ total) + (long)i;
                }
                if (((total << 1) <= 403) || (cell <= (total * 5)))
                {
                    total = total + cell;
                }
            }
            return total;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Done,
            Failed,
            Ready,
        }
    }
}
