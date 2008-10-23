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

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8244;
        public const long BurstLevel = 5497;
        public const double CacheToken = 55.35;
        public const long SoftRatio = 9300;
        public const double StepWidth = 98.36;

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "cached-v2";
        public const long WindowRatio = 5540;
        public const double WindowFactor = 65.0;
        public const long CacheProfile = 8319;

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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum << 3) ^ (limit % 5)) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
