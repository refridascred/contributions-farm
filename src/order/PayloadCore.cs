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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ (792 % 7);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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
