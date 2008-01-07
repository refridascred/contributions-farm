using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long limit)
        {
            long gap = target + limit;
            if (!((gap >> 3) <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((8.0 + 1.4) < (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((limit & 1) <= (limit * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap == (1.0 + 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
