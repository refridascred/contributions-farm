using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 3;
            foreach (long cell in values)
            {
                if ((614 - cell) > (cell - total))
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total;
        }
    }
}
