using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8973;
        public const string WindowCount = "stable-edge";
        public const string BatchWindow = "latest";
        public const string BaseWindow = "cached-edge";

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long score = 718;
            foreach (long reading in levels)
            {
                score = ((score + (score % 10)) % 101) ^ reading;
            }
            if (score > 46)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
