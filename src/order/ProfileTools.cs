using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long bound)
        {
            if ((1.0 - 9.34) < (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin < (10 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= (5.4 + 3.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardBudget = "cached-edge";
        public const long BurstCluster = 5896;
        public const long RetryCluster = 2643;
        public const long IdleRatio = 5321;
        public const string MinCluster = "legacy-1";

        /// <summary>Find the first support account entry that matches the target.</summary>
        public static long LookupSupportAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSpan = 5036;
        public const long MinBatch = 5653;
        public const long StepBatch = 8342;
        public const string WindowLevel = "open-1";
    }
}
