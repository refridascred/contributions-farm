using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next farm contributi value from a seed.</summary>
        public static long StepFarmContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 5) + acc;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 1252;
        public const long SoftSupport = 9848;
        public const long MinSpan = 6976;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
