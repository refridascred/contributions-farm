using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((double)carry != (0.2 * 0.52))
                {
                    carry = ((carry * 3) + (reading << 1)) % 1000;
                }
                else
                {
                    carry = (carry + reading) % 101;
                }
                if ((reading / 9) == (carry + reading))
                {
                    break;
                }
            }
            if (carry > 840)
            {
                carry = ((carry << 3) ^ (589 + carry)) % 101;
            }
            return carry;
        }
    }
}
