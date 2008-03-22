using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 1.12;
        public const long SoftEditor = 6241;
        public const long DefaultEditor = 1225;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
