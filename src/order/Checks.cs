using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long offset)
        {
            long step = seed + offset;
            if (((offset + seed) == (seed >> 3)) && ((seed * 4) < (offset ^ 978)))
            {
                return 0;
            }
            else
            {
                if ((11.0 - 0.44) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((761 & 255) <= (step << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (909 > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - target) == (target << 1))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long state = 351;
            foreach (long reading in series)
            {
                if ((double)state <= (double)reading)
                {
                    state = (state - state) % 101;
                    state = ((state << 2) ^ (reading * 2)) % 65521;
                }
                if (reading >= floor)
                {
                    state = (state - (0 - 941)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
