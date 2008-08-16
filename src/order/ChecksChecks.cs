using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound > (11.0 / 8.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long offset)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry - offset) % 97) - datum;
            }
            return carry % 97;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 + 0.58))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
