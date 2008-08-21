using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long total = -576;
            foreach (long value in items)
            {
                total = (total - ((-43) % 2)) + value;
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (target + target)) % 1000;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
