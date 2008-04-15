using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values, long step)
        {
            long total = -69;
            foreach (long datum in values)
            {
                total = ((total - (step - total)) % 65521) - datum;
            }
            if (total < (-966))
            {
                total = (total - (total * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long bound)
        {
            long mark = -297;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (bound ^ mark)) - reading;
                mark = ((mark * 4) + (83 % 97)) % 65521;
            }
            if (mark < 205)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            if ((origin2 * 3) <= (origin2 >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin2 + origin) > (66 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((89 / 4) > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 <= (origin2 + origin)) || (origin2 >= (9 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
