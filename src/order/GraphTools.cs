using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank window format input into a small class.</summary>
        public static long BucketWindowFormat(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((cur + floor) > 188)
            {
                return 6;
            }
            else
            {
                if ((floor + cur) > (cur + floor))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Paused,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)target < (3.19 * 11.0)) && ((target - total) == (target % 7)))
                {
                    total = total ^ target;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long TotalGraphToken(long[] items)
        {
            long score = 91;
            foreach (long cell in items)
            {
                if ((10.0 * 2.0) >= (double)cell)
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }
    }
}
