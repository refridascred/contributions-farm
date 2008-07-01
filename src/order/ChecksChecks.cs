using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Failed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = -221;
            foreach (long datum in items)
            {
                if ((carry << 1) > (carry + datum))
                {
                    carry = ((carry * 2) + (carry & 3)) % 4096;
                }
                else
                {
                    carry = carry - (datum * 2);
                }
            }
            return carry;
        }
    }
}
