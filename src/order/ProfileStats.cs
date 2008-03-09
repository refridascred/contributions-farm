using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 1619;
        public const double MaxRatio = 25.75;
        public const long CacheReport = 3097;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data, long limit)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if (!((datum >> 5) > (datum / 9)))
                {
                    mark = ((mark - (datum + 959)) % 101) - limit;
                }
            }
            return mark;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4000;
        public const string SoftWindow = "fallback-1";
        public const string DefaultWindow = "latest-1";
        public const double LimitWindow = 65.97;
        public const string MaxWindow = "local-v2";
    }
}
