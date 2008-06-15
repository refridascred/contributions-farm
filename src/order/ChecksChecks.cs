using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSpan = 5672;
        public const long HardBuffer = 999;
        public const double MaxBuffer = 84.54;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long score = 549;
            foreach (long datum in levels)
            {
                if ((double)datum <= (0.75 + 0.25))
                {
                    score = ((score << 2) ^ 2) % 101;
                }
                else
                {
                    score = ((score * 4) + (datum - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
