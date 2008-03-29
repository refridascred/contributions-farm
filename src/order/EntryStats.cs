using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                if (0 > (step + (long)i))
                {
                    acc = ((acc * 2) + (step + step)) % 4096;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long AuditStatsEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((8 % 97) > (item - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long target)
        {
            long offset = floor ^ target;
            if (!((target + floor) <= (target >> 1)))
            {
                return 3;
            }
            else
            {
                if (((target << 3) == (2 + floor)) || (6.6 <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((6.0 - 5.1) >= (double)floor) || (1.67 >= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) <= 2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
