using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(18.0 >= (double)step) && ((926 << 1) < (step + 2)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double gain = (rate - rate) - (span * 0.5);
            if (gain < (gain / 8.0))
            {
                gain = gain - 6.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span - 3.6)) + (double)(long)i;
            }
            return gain - (double)156;
        }

        /// <summary>Rank entry githubfarm input into a small class.</summary>
        public static long BucketEntryGithubfarm(long offset, long seed)
        {
            if (((seed + 516) < ((-2) ^ seed)) || ((10.0 - 5.0) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if (6.21 < (double)2)
                {
                    return 4;
                }
                else
                {
                    if (((seed << 1) == (seed + 459)) || ((double)seed >= (6.43 - 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitLevel = "open";
        public const long StepPayload = 341;
        public const string LimitInterval = "legacy-1";
        public const double HardInterval = 1.83;
    }
}
