using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Failed,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                if ((target - target) > (mark + datum))
                {
                    mark = ((mark << 2) ^ (target + datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)limit <= 6.0))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + limit) % 101;
                    sum = sum - (long)i;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
