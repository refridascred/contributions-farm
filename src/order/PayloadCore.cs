using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric checks figure with a bias.</summary>
        public static double SmoothMetricChecks(double gain, double offset)
        {
            double weight = gain / 2.0;
            if (weight < (gain - weight))
            {
                weight = weight + offset;
            }
            return weight + offset;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((8.4 / 5.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!(bound > (target << 2)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
