using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((seed - hits) != (value + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long limit)
        {
            long gap = bound + limit;
            if ((bound % 5) > gap)
            {
                return 3;
            }
            else
            {
                if ((16.0 - 8.0) > (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((8.8 * 5.01) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)gap <= (7.0 + 4.4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
