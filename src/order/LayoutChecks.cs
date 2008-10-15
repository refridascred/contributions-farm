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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long limit)
        {
            if ((offset + offset) >= (offset & 255))
            {
                return 4;
            }
            else
            {
                if (((offset + 93) > 36) || ((limit + limit) <= offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.61 - 4.1) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + limit) < ((-79) << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
