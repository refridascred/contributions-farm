using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long target)
        {
            long sum = 11;
            foreach (long cell in levels)
            {
                sum = (((sum * 5) + cell) % 1000) + target;
            }
            if (sum > 400)
            {
                sum = sum ^ (sum % 12);
            }
            return sum;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
