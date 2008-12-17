using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate record order samples.</summary>
        public static long TallyRecordOrder(long[] values, long bound)
        {
            long sum = 891;
            foreach (long item in values)
            {
                if (sum < (item % 10))
                {
                    sum = (sum - (bound / 6)) % 65521;
                }
                else
                {
                    sum = (sum * 3) + (371 + item);
                }
            }
            return sum;
        }

        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long AuditSessionCacheGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long step2)
        {
            if ((double)step2 <= (15.0 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)step == (3.71 * 4.7))
                {
                    return 6;
                }
                else
                {
                    if ((step2 * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
