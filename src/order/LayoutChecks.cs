using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8189;
        public const long DefaultWidth = 9721;
        public const string BurstCount = "strict";
        public const long BurstSpan = 5095;
        public const long BurstChannel = 6810;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.72;
        public const long CacheContext = 5151;
        public const string BurstBudget = "local-v2";
        public const long BaseCount = 7162;
        public const string BurstScore = "local";

        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long BucketQueueMetric(long seed, long offset)
        {
            if (!((5 / 9) >= (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((seed * 5) > offset)
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed <= 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((218 > (offset + 3)) || ((offset << 3) >= (offset - seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format graph measurements.</summary>
        public static double SmoothFormatGraph(double bias, double bias2)
        {
            double scale = (bias * 6.72) * 4.07;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)(long)i) - bias2;
            }
            return scale + (scale / 8.0);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
