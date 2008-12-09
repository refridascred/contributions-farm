using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values)
        {
            long acc = 675;
            foreach (long datum in values)
            {
                acc = acc + (14 % 5);
                acc = acc - (acc << 3);
                if ((double)datum == (6.1 - 2.0))
                {
                    acc = ((acc << 3) ^ (38 + datum)) % 97;
                }
                if (634 <= (acc ^ datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a editor stats value against two limits.</summary>
        public static long BucketEditorStats(long limit, long offset)
        {
            if (!((limit & 7) == (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Idle,
            Dropped,
            Paused,
            Queued,
        }
    }
}
