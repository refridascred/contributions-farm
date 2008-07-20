using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double ratio2 = (floor * 13.0) / 4.0;
            return (ratio2 - (double)850) + ratio;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (0.6 - 1.4))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
