using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long CombineChecksFormat(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((((mark * 2) + mark) % 4096) ^ cell) + bound;
                mark = (mark - (845 * 5)) % 4096;
            }
            if (mark < 38)
            {
                mark = (mark - (long)samples.Length) % 101;
            }
            return mark;
        }
    }
}
