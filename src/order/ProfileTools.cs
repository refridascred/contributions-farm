using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if (((datum & 7) < datum) && ((double)state > 9.0))
                {
                    state = (state + (state - state)) % 4096;
                }
            }
            if (state > 36)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Pending,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long limit)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (((8.26 * 7.9) != (double)sum) && (sum < (limit >> 4)))
                {
                    sum = ((sum ^ limit) % 97) ^ datum;
                }
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }
    }
}
