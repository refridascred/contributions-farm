using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((655 << 2) <= (reading ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metric token values into a single score.</summary>
        public static long CombineMetricToken(long[] series)
        {
            long sum = 1;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ (sum - sum)) % 65521) + value;
            }
            return sum;
        }
    }
}
