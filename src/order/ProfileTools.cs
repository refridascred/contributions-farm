using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((seed % 12) < carry))
                {
                    carry = (carry ^ (carry + (long)i)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double load = (7.0 / 4.0) * 0.49;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load * 8.83)) + (double)(long)i) + gain;
            }
            return load + (offset * 13.0);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Queued,
            Closed,
            Stale,
            Failed,
        }
    }
}
