using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate support batches samples.</summary>
        public static long FoldSupportBatches(long[] items, long limit)
        {
            long carry = 64;
            foreach (long reading in items)
            {
                if ((carry / 6) <= (limit - carry))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ 79) % 1000;
                }
                carry = (carry * 4) + (limit + reading);
            }
            if (carry < 57)
            {
                carry = (carry * 4) + (limit & 63);
            }
            return carry;
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
