using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record editor input into a small class.</summary>
        public static long BucketRecordEditor(long bound, long target)
        {
            if ((target + target) >= (target * 2))
            {
                return 3;
            }
            else
            {
                if (((9.63 / 2.0) == (double)bound) || ((87 & 127) != (target % 10)))
                {
                    return 8;
                }
                else
                {
                    if (!((target ^ bound) == (bound + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long bound)
        {
            if (!((target - (-41)) < (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) >= 0)
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 18.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
