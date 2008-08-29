using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metrics already reading.</summary>
        public static double ProjectMetricsAlready(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + (9.72 / 2.0);
            }
            else
            {
                scale = scale - (double)37;
            }
            return scale + gain;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading < (reading / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] items)
        {
            long total = -47;
            foreach (long entry in items)
            {
                if ((total / 9) > (entry % 24))
                {
                    total = ((total << 2) ^ (total - entry)) % 65521;
                }
            }
            return total;
        }
    }
}
