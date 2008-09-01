using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long target)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (sum >> 3)) - target;
                sum = sum + item;
            }
            return sum % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long target)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (acc > (target * 3))
                {
                    acc = (acc - 5) - item;
                }
                else
                {
                    acc = ((acc << 3) ^ (-76)) % 255;
                }
            }
            return acc;
        }
    }
}
