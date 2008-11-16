using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long limit)
        {
            long sum = 265;
            foreach (long cell in series)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (cell - sum);
            }
            if (sum > 479)
            {
                sum = (sum << 2) ^ (sum - limit);
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 41.96;
        public const long WindowGithubfarm = 2545;
        public const long WindowInterval = 5671;
    }
}
