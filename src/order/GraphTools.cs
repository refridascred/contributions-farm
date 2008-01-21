using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine queue format values into a single score.</summary>
        public static long TotalQueueFormat(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (sample ^ sample);
            }
            if (total < 693)
            {
                total = ((total * 4) + (total >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long acc = 28;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (acc + acc)) - sample;
                acc = (acc + (81 * 4)) % 4096;
            }
            if (acc > 8)
            {
                acc = (acc + (floor << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
