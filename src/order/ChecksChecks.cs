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

        /// <summary>Iterate the window graph series from a seed.</summary>
        public static long SeriesWindowGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (136 + floor)) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
