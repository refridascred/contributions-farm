using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long seed)
        {
            long anchor = -67;
            foreach (long cell in levels)
            {
                anchor = anchor - (36 * 2);
                if ((anchor >> 2) >= cell)
                {
                    anchor = anchor - (cell << 2);
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((-205) - seed)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long CountLayoutAccountMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((44 + 1) != ((-8) - limit)) && ((entry & 63) == (entry - 18)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double rate = 7.0 / 4.0;
            return (rate + (bias * 7.77)) + floor;
        }
    }
}
