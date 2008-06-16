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

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 7;
            foreach (long item in values)
            {
                if (result >= (result - 16))
                {
                    result = ((result + (664 / 7)) % 255) - item;
                }
            }
            return result;
        }
    }
}
