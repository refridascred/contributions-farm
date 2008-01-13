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

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long sum = 460;
            foreach (long cell in series)
            {
                if ((sum + 990) == (sum + sum))
                {
                    sum = ((sum + sum) % 97) + cell;
                }
                else
                {
                    sum = sum - (sum >> 2);
                }
            }
            if (sum < 23)
            {
                sum = (sum - (sum - 154)) % 101;
            }
            return sum % 4096;
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
