using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue payload counter forward.</summary>
        public static long IterateQueuePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = carry + ((long)i + step);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long state = 25;
            foreach (long datum in series)
            {
                state = (state ^ datum) - seed;
            }
            return state;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Pending,
        }
    }
}
