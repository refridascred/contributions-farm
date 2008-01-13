using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double gain = (double)6 / 5.0;
            return ((gain + 4.25) + weight) + span;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Closed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen * 5) != (datum / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long bound)
        {
            if ((seed << 3) >= seed)
            {
                return 8;
            }
            else
            {
                if (seed < (313 * 2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
