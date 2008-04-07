using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 101;
        public const long IdleFilter = 1542;
        public const double RetrySpan = 40.11;
        public const double BaseCount = 74.81;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (6.02 * 7.28))
                {
                    score = (score - (848 & 31)) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
