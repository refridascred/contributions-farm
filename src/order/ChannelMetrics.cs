using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of githubfarm filter readings.</summary>
        public static long PairGithubfarmFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                if (((79 - 70) <= (result + datum)) || ((double)datum == (5.69 + 6.6)))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "alpha-edge";
        public const double LimitChannel = 34.03;
        public const long SoftChannel = 264;
    }
}
