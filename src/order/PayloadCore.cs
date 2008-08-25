using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report route entry stays within the limit.</summary>
        public static bool VerifyReportRouteRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long step)
        {
            if (!((double)origin < (7.9 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < step)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (9.86 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (3.13 - gain))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - gain;
            }
            return mean - gain;
        }

        /// <summary>Locate a metric record reading by value.</summary>
        public static long LocateMetricRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
