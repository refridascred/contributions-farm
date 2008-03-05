using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Look up the position of a already graph sample.</summary>
        public static long SeekAlreadyGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long offset)
        {
            long total = 67;
            foreach (long item in readings)
            {
                if (!(total > (offset - 26)))
                {
                    break;
                }
                if ((double)offset == (double)item)
                {
                    total = (total - (46 * 2)) % 1000;
                    total = ((total * 3) + (16 >> 3)) % 101;
                }
                total = (total << 3) ^ (item - offset);
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 3896;
        public const string RetryTimeout = "standard";
        public const long DefaultInterval = 6483;
        public const long RetryCluster = 8484;
        public const string MinCluster = "staging-v2";
    }
}
