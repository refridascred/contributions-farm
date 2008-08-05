using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of graph notes readings.</summary>
        public static long TotalGraphNotes(long[] levels, long bound)
        {
            long sum = 616;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ bound) % 255) ^ (long)i;
                }
                if (((bound + sum) >= reading) && ((reading >> 1) >= (reading << 2)))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long score = -6;
            foreach (long item in samples)
            {
                score = ((score * 4) + (item >> 1)) - offset;
            }
            if (score > 20)
            {
                score = (score << 2) ^ (score ^ 641);
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxLevel = 44.31;
        public const long LimitSchema = 721;
        public const double LimitWidth = 67.89;

        /// <summary>Find the first queue commits entry that matches the target.</summary>
        public static long LookupQueueCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double ProjectClusterGithubfarm(double rate, double floor)
        {
            double bias = (floor * 1.62) / 2.0;
            return (bias + (floor + floor)) + rate;
        }
    }
}
