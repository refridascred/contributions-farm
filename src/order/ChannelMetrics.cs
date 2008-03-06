using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up githubfarm editor samples.</summary>
        public static long CompareGithubfarmEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double ScaleCacheSession(double scale, double offset)
        {
            double mean = scale;
            if (mean > 4.8)
            {
                mean = mean - offset;
            }
            return mean + (scale / 3.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 6777;
        public const long BatchRatio = 8835;
        public const long LimitSize = 7022;
    }
}
