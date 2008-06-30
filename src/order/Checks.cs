using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + seen) == (seen * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long floor, long target)
        {
            if ((floor ^ target) <= (767 >> 2))
            {
                return 3;
            }
            else
            {
                if (target <= (668 << 3))
                {
                    return 7;
                }
                else
                {
                    if (9.1 >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double span)
        {
            double load = (double)(0 >> 2);
            if (load >= (load / 9.0))
            {
                load = (load - 9.19) - weight;
            }
            return load - (span * 3.1);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 58.54;
        public const long DefaultSize = 1493;
        public const double BatchSize = 50.73;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((4.6 * 12.0) <= (double)entry) && ((floor > (entry + tally)) && ((19.0 + 18.0) <= (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
