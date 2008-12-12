using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Ready,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 3785;
        public const long SoftReport = 3289;
        public const long DefaultDepth = 3338;
        public const string MinSpan = "primary-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long span = floor - origin;
            if ((origin & 1) > origin)
            {
                return 8;
            }
            else
            {
                if (span < (span + 5))
                {
                    return 1;
                }
                else
                {
                    if ((span - 1) < 30)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double weight = 9.5;
            if (weight > (double)52)
            {
                weight = (weight - (scale - 3.2)) + bias;
            }
            return weight + weight;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Done,
        }
    }
}
