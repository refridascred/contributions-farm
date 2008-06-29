using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool ValidateCommitsReportLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit profile support readings against a rule.</summary>
        public static long AuditProfileSupportHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((1.64 - 15.0) != (double)hits) || (5.43 >= (double)cell)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Dropped,
            Ready,
            Draft,
            Retry,
        }
    }
}
