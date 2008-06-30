using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (offset >= (count + count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long origin)
        {
            if ((floor + floor) > (floor + 8))
            {
                return 6;
            }
            else
            {
                if ((18.0 + 9.1) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + item) > count)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
