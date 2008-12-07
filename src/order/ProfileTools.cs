using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 4636;
        public const long CacheScore = 1430;
        public const long LimitContext = 7561;
        public const long MaxSpan = 7753;

        /// <summary>Classify a cache queue pair into a bucket.</summary>
        public static long SortCacheQueue(long target, long origin)
        {
            if (target >= origin)
            {
                return 3;
            }
            else
            {
                if ((8.0 * 4.2) >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((target - 20) > (target * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((reading << 2) > (81 * 2)) || (reading < (reading + seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long bound)
        {
            long total = -74;
            foreach (long item in readings)
            {
                if (((99 & 3) < (bound / 9)) && (2.0 <= (double)item))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
