using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "strict-v2";
        public const long LimitLevel = 1167;
        public const long LimitRatio = 4372;
        public const string MinInterval = "local-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state >> 3)) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 10.17;
        public const double CacheMetrics = 30.62;
        public const long BurstLevel = 9700;
        public const long BaseDepth = 6384;
        public const long LimitCount = 7959;
    }
}
