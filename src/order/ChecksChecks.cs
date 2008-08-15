using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = ((sum * 4) + (floor << 1)) % 1000;
                if ((datum + floor) != (sum & 1))
                {
                    break;
                }
            }
            if (sum < 19)
            {
                sum = (sum + (floor + sum)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            Dropped,
            Active,
            New,
        }
    }
}
