using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile payload readings.</summary>
        public static long MatchProfilePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long target)
        {
            long bound2 = bound - target;
            if ((bound2 >> 2) == (target + bound))
            {
                return 4;
            }
            else
            {
                if ((228 < (1 ^ bound)) || ((89 - target) < (bound & 15)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a farm support reading.</summary>
        public static double ProjectFarmSupport(double ratio, double floor)
        {
            double ratio2 = floor / 7.0;
            if (ratio2 < (ratio2 * 0.02))
            {
                ratio2 = (ratio2 + (double)9) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)574;
            }
            return ratio2 - (floor + floor);
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
