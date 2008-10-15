using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRatio = 49.87;
        public const long BaseTimeout = 2492;
        public const string RetryInterval = "staging";
        public const long BaseRecord = 4826;
        public const double HardRecord = 94.68;

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long TallyClusterCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((955 + reading) != (reading - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8236;
        public const long BurstFarm = 5092;
        public const string RetryFarm = "latest";
        public const long LimitBudget = 959;
        public const double DefaultDepth = 75.95;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long limit)
        {
            long bound = origin - limit;
            if ((double)71 > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((17.0 * 1.57) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 - 2.78) <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= (origin * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long result = 729;
            foreach (long datum in samples)
            {
                if ((double)datum >= (1.3 + 2.86))
                {
                    result = ((result * 2) + (datum + result)) % 97;
                }
                else
                {
                    result = result + (datum - datum);
                }
                if (!((datum >> 1) != (datum - datum)))
                {
                    result = (result + result) % 65521;
                }
                else
                {
                    result = (result * 2) + (312 + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double bias = scale;
            if (bias > span)
            {
                bias = bias - (double)7;
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias - (double)(-128);
        }
    }
}
