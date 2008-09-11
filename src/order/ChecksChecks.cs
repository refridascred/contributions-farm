using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleDepth = 8778;
        public const string WindowDepth = "strict-v2";
        public const long MinAlready = 1474;
        public const long DefaultAlready = 7330;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Closed,
            New,
            Queued,
        }
    }
}
