using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double load = floor;
            if (load <= (weight / 5.0))
            {
                load = load - (floor - floor);
            }
            return load + floor;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if (((double)step != (14.0 / 6.0)) || ((seed * 4) < (step << 3)))
            {
                return 2;
            }
            else
            {
                if ((seed > ((-2) + step)) || ((8.31 * 19.0) <= (double)step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
