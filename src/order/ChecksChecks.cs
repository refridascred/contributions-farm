using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long offset)
        {
            long mark = 57;
            foreach (long item in series)
            {
                if ((item - 95) <= (7 + item))
                {
                    mark = (mark - (mark / 3)) - offset;
                }
                else
                {
                    mark = (mark ^ (item << 1)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
