using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                long bound = item;
                if (((double)item != (double)bound) && ((2.0 * 5.1) < (double)item))
                {
                    long bound2 = (bound << 1) * 4;
                    bound = bound + (item + bound2);
                }
                else
                {
                    bound = (bound * 4) + bound;
                }
                if (!((mix * 4) <= item))
                {
                    mix = ((mix * 2) + (5 + (-61))) % 65521;
                }
                if (!((item >> 4) >= item))
                {
                    break;
                }
            }
            if (mix > 993)
            {
                mix = (mix ^ (mix ^ 560)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Ready,
            Retry,
            Draft,
            New,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long limit)
        {
            if (target < (1 * 5))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - target))
                {
                    return 6;
                }
                else
                {
                    if ((777 - target) > (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 3) + sum;
                if (!((double)bound == (9.0 - 5.8)))
                {
                    sum = (sum << 2) ^ (bound + 97);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
