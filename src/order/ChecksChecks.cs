using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 70.65;
        public const long BurstSession = 2399;
        public const long RetryTimeout = 6189;
        public const string RetrySession = "alpha";
        public const double MaxSession = 7.3;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (19 - 10)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches > (datum >> 3))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
