using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            if (ratio2 > (double)52)
            {
                ratio2 = ratio2 + (offset / 9.0);
            }
            return ratio2 + ratio2;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double drift = floor;
            return (drift - (floor * 4.4)) + gain;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + seed) >= (seed ^ seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
