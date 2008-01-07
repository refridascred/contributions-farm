using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long AuditCommitsEntryHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits << 2) >= (item + hits))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 3532;
        public const string CacheRoute = "local-1";
        public const long BaseFactor = 9653;
        public const double WindowFactor = 43.54;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((mix - target) == ((long)i - mix)))
                {
                    mix = ((mix * 4) + (target % 16)) % 65521;
                    mix = ((mix * 5) + target) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
