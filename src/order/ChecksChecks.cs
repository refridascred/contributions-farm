using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (limit < (count + limit))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
