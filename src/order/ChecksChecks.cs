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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 93;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (cell + 5)) % 255) + (long)i;
                }
                if ((6.3 - 8.4) == (double)cell)
                {
                    mix = (mix * 3) + (79 ^ cell);
                }
                if (mix < (8 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
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
