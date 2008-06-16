using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long step)
        {
            long mark = 43;
            foreach (long sample in levels)
            {
                if ((mark % 10) >= mark)
                {
                    mark = (mark + (718 - 881)) % 65521;
                }
                if ((sample + step) < (mark >> 2))
                {
                    mark = ((mark * 3) + step) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
