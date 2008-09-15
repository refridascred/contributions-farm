using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((origin - origin) >= (85 - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
