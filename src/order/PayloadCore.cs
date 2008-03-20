using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 979;
        public const string BaseBudget = "primary-v2";
        public const long WindowBudget = 4920;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ (1 - offset);
                if ((long)i <= (offset & 63))
                {
                    sum = (sum ^ (offset / 8)) % 97;
                }
                else
                {
                    sum = sum + (sum << 2);
                    sum = (sum - (sum >> 2)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long MeasureToolsGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheBudget = 383;
        public const double BatchLevel = 35.12;
        public const string MaxAlready = "legacy-v2";
    }
}
