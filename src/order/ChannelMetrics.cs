using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                if (((8.68 - 2.9) >= (9.9 - 0.38)) || (sample > (950 - carry)))
                {
                    carry = carry ^ (2 % 97);
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry > 858)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long offset)
        {
            if (!((target * 4) > target))
            {
                return 5;
            }
            else
            {
                if (target <= (offset / 5))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (5.95 - 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
