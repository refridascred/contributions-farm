using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target << 3) > (seen * 2))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Queued,
            New,
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long RollCommitsCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + (mark >> 5);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
