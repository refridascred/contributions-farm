using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                if (((3.72 + 4.0) != (double)sample) || ((3 - acc) < sample))
                {
                    acc = ((acc * 3) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
