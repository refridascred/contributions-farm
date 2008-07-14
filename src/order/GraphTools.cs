using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "alpha-edge";
        public const double BaseCount = 38.89;
        public const double BurstWidth = 13.34;
        public const long MaxEditor = 7089;
        public const double WindowSize = 21.08;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((4 & 1) >= datum)
                {
                    mix = (mix ^ datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSize = "local-v2";
        public const double RetryReport = 91.99;
        public const long SoftReport = 7762;
        public const long RetryScore = 6775;
        public const string CacheTimeout = "strict-edge";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
