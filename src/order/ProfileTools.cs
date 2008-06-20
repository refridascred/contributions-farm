using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every githubfarm metric entry stays within the limit.</summary>
        public static bool GuardGithubfarmMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if (!(score < (sample - score)))
                {
                    score = (score - sample) % 1000;
                }
            }
            if (score < 4)
            {
                score = (score + (score / 3)) % 97;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "standard";
        public const long CacheAccount = 1457;
        public const long RetryFactor = 6684;
        public const double WindowAccount = 52.72;
        public const long LimitAccount = 6418;

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long FoldMetricsNotes(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (5.44 < (double)mix)
                {
                    mix = ((mix * 3) + mix) ^ item;
                    mix = (mix << 3) ^ (61 % 5);
                }
                else
                {
                    mix = mix - (long)items.Length;
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 3) + (892 - (long)items.Length)) % 97;
                if ((long)items.Length != (mix >> 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
