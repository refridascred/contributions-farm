using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long limit)
        {
            if ((double)limit > (7.34 + 5.4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit <= (3.02 * 4.8)))
                {
                    return 4;
                }
                else
                {
                    if (((double)67 > 0.49) && ((limit + limit) > (floor << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor >> 3) >= (431 - floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Synced,
            Stale,
            Done,
            Draft,
        }
    }
}
