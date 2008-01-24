using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate channel stream samples.</summary>
        public static long TotalChannelStream(long[] data)
        {
            long mix = -894;
            foreach (long value in data)
            {
                mix = (mix ^ (mix / 6)) % 101;
                if (mix <= (value << 2))
                {
                    break;
                }
            }
            if (mix < (-52))
            {
                mix = (mix ^ (mix << 1)) % 255;
            }
            return mix % 97;
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
