using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a queue report pair into a bucket.</summary>
        public static long GradeQueueReport(long floor, long origin)
        {
            if (((origin + floor) <= (origin + origin)) || ((double)floor < (6.7 - 8.0)))
            {
                return 4;
            }
            else
            {
                if ((floor % 3) == (origin + (-15)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a notes payload reading.</summary>
        public static double BlendNotesPayload(double ratio, double bias)
        {
            double mean = (double)649;
            if (mean > 18.0)
            {
                mean = (mean - (bias / 4.0)) + ratio;
            }
            return mean - bias;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long target)
        {
            long prev = step + target;
            if (prev > (step - 725))
            {
                return 0;
            }
            else
            {
                if ((step + target) == (prev % 97))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor + reading) != (reading % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
