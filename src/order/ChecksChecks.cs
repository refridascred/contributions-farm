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

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = (acc - (entry / 9)) % 65521;
                if ((6.88 + 6.01) > (double)acc)
                {
                    acc = acc ^ (origin * 2);
                }
            }
            if (acc > (-8))
            {
                acc = acc + ((-720) / 7);
            }
            return acc;
        }
    }
}
