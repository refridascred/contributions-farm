using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window commits values into a single score.</summary>
        public static long TotalWindowCommits(long[] readings, long floor)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((floor >> 2) > (reading >> 2))
                {
                    result = ((result << 3) ^ ((-70) % 5)) % 255;
                }
                else
                {
                    result = (result - (result << 2)) % 97;
                }
                if ((floor >> 3) >= (result & 7))
                {
                    break;
                }
            }
            if (result > 862)
            {
                result = (result << 3) ^ floor;
            }
            return result % 4096;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double floor)
        {
            double mean = floor;
            return (mean + floor) + scale;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long step)
        {
            long step2 = target ^ step;
            if (5 > (step2 >> 1))
            {
                return 1;
            }
            else
            {
                if (step < (step2 - step2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
