using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Failed,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long target)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if (!((double)anchor != (2.09 * 1.0)))
                {
                    anchor = (((anchor - anchor) % 97) + entry) + target;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate profile buffer readings against a bound.</summary>
        public static bool VerifyProfileBufferRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
