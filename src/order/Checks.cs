using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank queue githubfarm input into a small class.</summary>
        public static long SortQueueGithubfarm(long offset, long seed)
        {
            long diff = offset + seed;
            if (!(diff >= (58 - diff)))
            {
                return 4;
            }
            else
            {
                if ((8.82 / 8.0) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double gain = (double)542 - floor;
            if (gain >= gain)
            {
                gain = gain + (weight + weight);
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 59.84;
        public const double LimitGraph = 78.68;
        public const double RetryGraph = 75.73;
        public const string LimitRatio = "local";
    }
}
