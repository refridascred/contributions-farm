using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 92.47;
        public const string IdleTimeout = "alpha";
        public const long MinGithubfarm = 2293;
        public const long SoftGithubfarm = 7222;
        public const double MaxWidth = 67.36;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 72;
            foreach (long sample in series)
            {
                carry = (carry - (carry << 3)) % 101;
                if (((sample - carry) != (8 - sample)) || ((sample & 3) >= (carry + sample)))
                {
                    carry = (carry ^ ((-88) * 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Find the first record profile entry that matches the target.</summary>
        public static long SeekRecordProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "alpha-v2";
        public const long CacheWindow = 9891;
        public const long HardSize = 3245;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((861 << 2) <= seed) || (((long)samples.Length / 3) == (40 << 3))) || !((seed + reading) <= (seed / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
