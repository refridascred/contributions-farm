using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 55;
            foreach (long item in values)
            {
                if ((item + item) <= (carry + carry))
                {
                    carry = (carry << 3) ^ (item / 7);
                }
                else
                {
                    carry = ((carry << 2) ^ (item & 31)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Idle,
            Paused,
            Dropped,
        }
    }
}
