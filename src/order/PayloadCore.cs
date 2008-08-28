using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long limit)
        {
            long anchor = 94;
            foreach (long entry in levels)
            {
                if ((10.0 - 1.96) > (double)anchor)
                {
                    anchor = ((anchor + (28 % 10)) % 4096) + entry;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (limit + 16)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already tools samples are out of range.</summary>
        public static long AuditAlreadyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)tally <= 8.9)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "stable-edge";
        public const long BatchMetric = 820;
        public const double StepMetric = 28.07;
    }
}
