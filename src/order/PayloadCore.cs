using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values)
        {
            long sum = -526;
            foreach (long cell in values)
            {
                if ((sum % 60) < sum)
                {
                    continue;
                }
                if (!(sum >= (sum + 386)))
                {
                    sum = ((sum - (sum >> 1)) % 1000) ^ cell;
                }
            }
            if (sum < 612)
            {
                sum = sum - (776 + 58);
            }
            return sum;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 5) > (matches + matches))
                {
                    matches = ((matches + 2) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
