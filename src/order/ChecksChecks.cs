using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = (double)(2 + 1);
            if (ratio2 >= bias)
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + ratio;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((offset >> 4) <= 3)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
