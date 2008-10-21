using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long limit)
        {
            long step = offset - limit;
            if ((double)step < (2.5 * 0.8))
            {
                return 8;
            }
            else
            {
                if (((-9) & 1) <= (limit ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((limit <= (limit - 10)) || ((15.0 + 4.2) <= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((47 / 4) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
