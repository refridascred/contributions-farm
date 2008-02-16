using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseDepth = 19.66;
        public const string WindowWidth = "open-v2";
        public const long MaxCommand = 6250;
        public const long LimitCommand = 7752;
        public const double BaseBudget = 16.73;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)704 <= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                total = (total + (sample - 9)) + offset;
            }
            if (total > 152)
            {
                total = ((total << 3) ^ (total >> 2)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long seed)
        {
            if (!((limit % 2) < 80))
            {
                return 6;
            }
            else
            {
                if ((seed << 3) <= (seed & 127))
                {
                    return 7;
                }
                else
                {
                    if (limit < (seed % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
