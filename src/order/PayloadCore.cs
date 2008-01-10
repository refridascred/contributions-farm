using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long sum = 934;
            foreach (long cell in items)
            {
                if ((sum + (long)items.Length) == (cell % 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (cell - cell)) % 4096;
                }
                sum = sum + (cell + cell);
                if (((16.0 / 6.0) <= (double)sum) && ((double)782 > (double)sum))
                {
                    sum = ((sum * 3) + (cell * 5)) % 97;
                }
                else
                {
                    sum = sum - (cell >> 2);
                }
            }
            if (sum > 60)
            {
                sum = (sum ^ (sum >> 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 5150;
        public const long MinMetrics = 106;
        public const long MaxMetrics = 651;
        public const long BurstMetrics = 3261;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9928;
        public const double MaxAlready = 66.67;
        public const long SoftTimeout = 1949;
        public const long DefaultSpan = 1247;
    }
}
