using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - 1) % 101) - (long)i2;
                }
                if (!((418 + limit) > (73 + limit)))
                {
                    score = (score + 5) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long anchor = -357;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (item << 1)) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor << 2)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7052;
        public const string DefaultTools = "primary";
        public const string BatchTools = "latest-edge";
        public const double CacheTools = 54.57;
        public const string MaxTools = "open";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
