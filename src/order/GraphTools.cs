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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values, long seed)
        {
            long sum = 9;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + sum) + sample;
                if (!!((seed - seed) <= (41 - seed)))
                {
                    sum = (sum - (seed & 7)) % 255;
                }
                if ((10.0 + 1.93) <= (double)seed)
                {
                    sum = (sum ^ 6) % 65521;
                }
            }
            return sum;
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
