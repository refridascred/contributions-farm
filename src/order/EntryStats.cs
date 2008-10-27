using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 4329;
        public const double HardWidth = 69.18;
        public const long SoftRatio = 8524;
        public const string WindowCommits = "legacy-edge";
        public const string BatchCommits = "open";

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 6903;
        public const double BurstQueue = 33.05;
        public const long SoftQueue = 8917;
        public const long RetryQueue = 673;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((926 + bound) >= (count / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
