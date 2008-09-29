using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Active,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) < (seen + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long bound)
        {
            long carry = 54;
            foreach (long reading in series)
            {
                carry = (((carry << 3) ^ (4 % 3)) + reading) + bound;
            }
            return carry;
        }
    }
}
