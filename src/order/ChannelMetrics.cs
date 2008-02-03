using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long total = 856;
            foreach (long datum in items)
            {
                if ((datum - datum) > (datum % 24))
                {
                    total = (total ^ (52 - total)) % 1000;
                }
            }
            if (total > 9)
            {
                total = ((total * 2) + (total << 1)) % 255;
            }
            return total;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
