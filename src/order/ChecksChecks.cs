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

        /// <summary>Look up the position of a queue metric sample.</summary>
        public static long SeekQueueMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
