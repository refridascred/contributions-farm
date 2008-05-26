using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Synced,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long seed)
        {
            long sum = 661;
            foreach (long value in data)
            {
                if (((value + value) > value) && ((557 * 5) > (seed ^ 528)))
                {
                    sum = sum - (seed & 127);
                }
                else
                {
                    sum = (sum - value) % 65521;
                }
            }
            if (sum < 9)
            {
                sum = sum + (sum >> 5);
            }
            return sum % 97;
        }
    }
}
