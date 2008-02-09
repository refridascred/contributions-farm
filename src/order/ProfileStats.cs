using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long carry = 99;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ 33) % 1000;
                if (!((item & 15) < item))
                {
                    break;
                }
            }
            if (carry > 833)
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
