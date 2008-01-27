using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool VerifyStatsTokenBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 35.07;
        public const long SoftScore = 4774;
        public const long MinSize = 8785;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (offset2 * 3))
            {
                return 8;
            }
            else
            {
                if (((target + target) == (9 + offset2)) && ((offset + 9) < offset2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
