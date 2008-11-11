using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long seed)
        {
            if ((seed % 5) > (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed % 7) != (519 % 60))
                {
                    return 5;
                }
                else
                {
                    if (4.7 <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((167 / 5) < (floor & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSpan = 820;
        public const string SoftChannel = "local-edge";
        public const string LimitSpan = "cached-v2";
        public const long CacheLevel = 2769;
    }
}
