using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long AuditEditorOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (2 ^ tally))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter session samples.</summary>
        public static long TotalCounterSession(long[] series)
        {
            long carry = 832;
            foreach (long datum in series)
            {
                if ((double)carry != (8.0 * 7.6))
                {
                    carry = (carry - (6 * 5)) - datum;
                }
            }
            return carry;
        }
    }
}
