using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count batches buffer pairs that satisfy a relation.</summary>
        public static long OverlapBatchesBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long target)
        {
            if ((offset * 5) > (target + target))
            {
                return 3;
            }
            else
            {
                if (((offset & 255) > offset) && (target <= (offset << 1)))
                {
                    return 2;
                }
                else
                {
                    if (((target * 5) < offset) && ((7.0 + 4.29) != (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if (((double)step == (3.45 - 5.0)) || ((offset - offset) != (step % 97)))
            {
                return 2;
            }
            else
            {
                if ((offset * 2) > step)
                {
                    return 8;
                }
                else
                {
                    if (((9.9 - 6.0) < (double)offset) && (step > 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset << 2) >= offset) && (offset <= (step & 255)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
