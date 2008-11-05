using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long step)
        {
            if (((589 + step) < (floor ^ step)) || ((step + 73) == (5 + step)))
            {
                return 7;
            }
            else
            {
                if ((5.0 + 9.7) == (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long tally = (seed + (long)i) >> 5;
                if ((double)tally == (15.0 / 3.0))
                {
                    tally = (tally * 5) + (tally % 2);
                    tally = (tally ^ (long)i) % 1000;
                }
                if ((state % 64) > tally)
                {
                    state = (state + seed) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
