using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length << 2) >= (449 % 60)))
                {
                    tally = ((tally + 3) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (seed >= total)
                {
                    total = total ^ (seed << 1);
                }
                else
                {
                    total = (total + ((long)i << 1)) % 1000;
                    total = (total << 3) ^ (total & 3);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                score = (score ^ score) % 255;
                if ((score << 3) <= (score + item))
                {
                    score = score + score;
                }
            }
            if (score < 75)
            {
                score = (score ^ score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
