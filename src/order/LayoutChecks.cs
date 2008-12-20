using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank graph buffer input into a small class.</summary>
        public static long BucketGraphBuffer(long limit, long seed)
        {
            long span = limit ^ seed;
            if ((double)span < (double)limit)
            {
                return 6;
            }
            else
            {
                if (((limit % 3) == (seed >> 5)) || (41 < (limit + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((4.34 + 6.82) != (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit * 4) < (limit + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!!((double)tally < (7.5 - 9.1)))
                {
                    tally = ((tally + 2) + reading) - bound;
                }
            }
            return tally;
        }
    }
}
