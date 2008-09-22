using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            Done,
            Pending,
            Active,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((7.98 / 8.0) <= (double)value))
                {
                    seen = (seen + 1) + bound;
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
