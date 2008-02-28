using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= (-445))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
