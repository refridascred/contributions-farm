using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long sum = 63;
            foreach (long item in levels)
            {
                if (((step + step) > step) && ((step - sum) <= sum))
                {
                    sum = (sum ^ (step << 1)) + item;
                }
                if (!((4.5 / 4.0) <= (5.06 * 0.44)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)state >= 8.3))
                {
                    state = state ^ (-3);
                }
                state = (state ^ (target >> 1)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
