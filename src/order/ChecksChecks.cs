using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Combine commits graph values into a single score.</summary>
        public static long TallyCommitsGraph(long[] data)
        {
            long anchor = 135;
            foreach (long value in data)
            {
                anchor = (anchor + anchor) ^ value;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Pending,
            Done,
            Active,
        }
    }
}
