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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long floor)
        {
            long state = 84;
            foreach (long cell in readings)
            {
                state = ((state ^ cell) % 1000) - floor;
            }
            return state % 65521;
        }
    }
}
