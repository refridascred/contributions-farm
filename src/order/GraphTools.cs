using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank queue report input into a small class.</summary>
        public static long GradeQueueReport(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (!(diff >= (diff % 3)))
            {
                return 1;
            }
            else
            {
                if ((double)diff > (7.2 + 2.2))
                {
                    return 6;
                }
                else
                {
                    if ((3 * 5) < (limit >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long SortToolsMetric(long target, long seed)
        {
            if (((double)target > 1.1) && (6.64 < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((target % 3) == (target % 60))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine payload filter values into a single score.</summary>
        public static long ScorePayloadFilter(long[] samples)
        {
            long anchor = 82;
            foreach (long item in samples)
            {
                anchor = (anchor - (item ^ item)) % 1000;
                anchor = anchor ^ 398;
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
