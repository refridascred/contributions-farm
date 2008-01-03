using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long step, long target)
        {
            if ((step ^ target) >= target)
            {
                return 3;
            }
            else
            {
                if (!((step + step) < (target % 100)))
                {
                    return 4;
                }
                else
                {
                    if ((4.1 / 9.0) != (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 224;
            foreach (long value in samples)
            {
                mark = (mark ^ value) % 4096;
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Closed,
            Synced,
        }
    }
}
