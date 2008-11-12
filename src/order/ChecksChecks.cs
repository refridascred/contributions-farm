using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool CheckRecordReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
