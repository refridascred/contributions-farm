using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry graph samples.</summary>
        public static long TotalEntryGraph(long[] items)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if ((datum % 2) <= (datum << 2))
                {
                    carry = (carry + (datum ^ (long)items.Length)) % 1000;
                    carry = (carry - datum) % 101;
                    break;
                }
                else
                {
                    carry = (carry ^ (294 + carry)) % 4096;
                }
                if ((carry - datum) == ((-574) ^ carry))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 478)
            {
                carry = ((carry << 2) ^ (carry % 7)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Rank command batches input into a small class.</summary>
        public static long BucketCommandBatches(long step, long offset)
        {
            if ((offset % 7) <= (offset - 0))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((3.09 - 4.24) != (double)offset) && ((offset * 3) > (45 / 6)))
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
}
