using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 4593;
        public const long HardDepth = 398;
        public const long SoftQueue = 983;
        public const long HardQueue = 5321;
    }
}
