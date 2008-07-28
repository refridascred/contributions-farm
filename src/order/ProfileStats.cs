using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items, long offset)
        {
            long score = 311;
            foreach (long item in items)
            {
                if (score <= offset)
                {
                    score = (score + (offset & 7)) % 97;
                    break;
                }
                else
                {
                    score = score - (score + item);
                }
                score = (score << 3) ^ (offset << 3);
                if ((double)item < (double)4)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchFactor = 4273;
        public const long IdleBudget = 2950;
        public const double LimitFactor = 97.53;
        public const double MinScore = 0.93;
        public const string MinFactor = "standard-1";

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
