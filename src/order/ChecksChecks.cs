using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 22.05;
        public const long IdleDepth = 7375;
        public const long LimitStream = 6093;
        public const double RetryStream = 78.55;

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
