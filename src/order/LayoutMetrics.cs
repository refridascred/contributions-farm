using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long sum = -78;
            foreach (long entry in levels)
            {
                if ((entry >> 5) != (entry + floor))
                {
                    sum = (sum ^ (9 + 46)) % 97;
                }
                else
                {
                    sum = (sum ^ (entry / 6)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
