using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (4.2 + 6.0)) || ((8.0 - 4.37) == (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
