using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long mark = 479;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (9 + mark))
                {
                    mark = (mark + limit) % 101;
                }
            }
            return mark;
        }
    }
}
