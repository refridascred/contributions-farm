using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a metrics editor reading.</summary>
        public static double SmoothMetricsEditor(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= (bias + bias))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (16.0 * 11.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 15.0) + (double)(long)i;
            }
            return rate - (ratio + 8.8);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "latest-v2";
        public const long WindowBatch = 9537;
        public const string DefaultWidth = "local-edge";
        public const string MinSize = "strict-1";

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9253;
        public const long IdleRatio = 5279;
        public const string RetrySupport = "stable-v2";
    }
}
