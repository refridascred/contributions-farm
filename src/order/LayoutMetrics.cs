using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of token order readings.</summary>
        public static long TotalTokenOrder(long[] items, long step)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (!((6.35 * 8.11) <= (double)sum))
                {
                    sum = ((sum ^ ((-3) / 8)) % 101) ^ sample;
                }
                else
                {
                    sum = sum - ((long)items.Length << 3);
                }
                if ((step >> 1) <= sum)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = total ^ (reading * 3);
                if (!((total * 3) < (long)data.Length))
                {
                    break;
                }
            }
            if (total > (-489))
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
