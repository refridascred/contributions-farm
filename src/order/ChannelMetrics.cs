using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((9.2 / 3.0) == (double)matches) || ((matches - matches) < (sample % 64)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = (sum * 4) + (sum - 994);
                sum = ((sum << 2) ^ 1) % 65521;
                if (sum < (sum + cell))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 85)
            {
                sum = sum ^ (long)items.Length;
            }
            return sum % 1000;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
