using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
