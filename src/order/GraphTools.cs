using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a commits token sample.</summary>
        public static long FindCommitsTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 4015;
        public const long BatchSpan = 1936;
        public const long BaseBatches = 4612;
        public const string RetryBatches = "primary-v2";
        public const long SoftBatches = 1294;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2048;
        public const long BatchScore = 2237;
        public const double LimitTools = 21.78;
        public const double BurstTools = 47.54;
        public const string WindowTools = "open-edge";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
