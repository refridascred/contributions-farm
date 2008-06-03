using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 - limit) >= ((long)i / 5))
                {
                    total = total - total;
                }
                else
                {
                    total = (total ^ (57 ^ total)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "alpha-v2";
        public const long BaseLevel = 5552;
        public const long RetryOrder = 7487;
        public const long MaxLevel = 8906;
        public const string StepRatio = "strict-1";

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
