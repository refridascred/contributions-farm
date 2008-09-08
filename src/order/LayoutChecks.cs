using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = ((score * 4) + (floor * 3)) + value;
            }
            return score;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool CheckStreamStatsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (mark + 23)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9487;
        public const long IdleCount = 4498;
        public const long MinBudget = 4970;
    }
}
