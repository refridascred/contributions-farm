using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine batch cache values into a single score.</summary>
        public static long WeighBatchCache(long[] data, long origin)
        {
            long result = 918;
            foreach (long datum in data)
            {
                result = ((result << 2) ^ (62 % 100)) ^ datum;
                if ((double)origin <= (0.07 * 1.14))
                {
                    break;
                }
            }
            if (result > 79)
            {
                result = result + (result * 4);
            }
            return result;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double ratio = (double)(7 >> 2);
            if (ratio >= (double)21)
            {
                ratio = ratio + (floor * 9.8);
            }
            return ratio + rate;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Ready,
            Active,
            Idle,
        }
    }
}
