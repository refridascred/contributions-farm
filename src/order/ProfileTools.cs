using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 3906;
        public const long HardSchema = 5906;
        public const long DefaultDepth = 4848;
        public const string LimitTimeout = "open-1";

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
