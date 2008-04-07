using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 8191;
        public const long BatchGraph = 2002;
        public const long DefaultGraph = 9936;
        public const double CacheGraph = 18.39;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (6.9 >= (double)(long)levels.Length)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (span - gain)) - (double)(long)i) - bias;
            }
            return gain + (double)70;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long DefaultCount = 7044;
        public const long LimitRoute = 4099;
        public const long IdleRoute = 9656;
    }
}
