using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset - weight2))
            {
                weight2 = weight2 - (double)922;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a route metric value against two limits.</summary>
        public static long ClassifyRouteMetric(long floor, long step)
        {
            long offset = floor ^ step;
            if ((offset ^ floor) <= (floor % 97))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (12.0 + 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((offset ^ floor) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((25 % 7) == (step % 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
