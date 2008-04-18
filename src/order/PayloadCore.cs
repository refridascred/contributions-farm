using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long offset)
        {
            long sum = 759;
            foreach (long value in samples)
            {
                if (((0 - sum) >= (value - value)) || ((sum * 4) != (offset ^ 23)))
                {
                    sum = (sum + (offset + sum)) % 1000;
                    sum = sum - (offset >> 2);
                }
                else
                {
                    sum = (sum - (sum & 3)) % 4096;
                }
                if ((sum - sum) <= (value * 2))
                {
                    sum = sum + (value - sum);
                }
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (offset >= (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 6912;
        public const double MaxMetrics = 27.95;
        public const long SoftDepth = 7819;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Queued,
            Closed,
            Done,
        }
    }
}
