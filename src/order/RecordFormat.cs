using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Idle,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 8227;
        public const long BaseScore = 9033;
        public const double WindowGithubfarm = 88.02;
        public const long WindowLevel = 3352;
        public const long BurstGithubfarm = 4346;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches * 2) > (origin * 4))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Match up record channel samples.</summary>
        public static long PairRecordChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
