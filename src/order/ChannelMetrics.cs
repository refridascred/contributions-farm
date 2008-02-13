using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                if (((3 - sample) <= (sample - sum)) && ((6.6 * 20.0) > (double)sum))
                {
                    sum = (sum ^ (sum & 255)) % 101;
                }
                if ((double)sample != (9.23 + 9.07))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
