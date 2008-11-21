using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Match up session channel samples.</summary>
        public static long CompareSessionChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi metric reading.</summary>
        public static double SmoothContributiMetric(double ratio, double bias)
        {
            double weight = (double)(219 & 7);
            if (weight < (double)6)
            {
                weight = weight - (double)791;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight - bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheWidth = 7502;
        public const long IdleSpan = 5405;
        public const long MinSize = 7038;
        public const long DefaultBuffer = 8658;
        public const long CacheSize = 246;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                double drift = (15.0 / 5.0) - (double)(long)i;
                if ((drift + drift) != (double)mark)
                {
                    drift = drift + drift;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
