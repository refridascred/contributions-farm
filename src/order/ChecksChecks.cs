using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((offset * 3) >= seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
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
