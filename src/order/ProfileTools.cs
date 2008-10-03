using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long carry = 302;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ limit) % 101;
                carry = ((carry * 5) + (limit ^ cell)) % 4096;
            }
            if (carry < 648)
            {
                carry = (carry - (limit % 97)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of metric commits readings.</summary>
        public static long FoldMetricCommits(long[] data)
        {
            long state = 691;
            foreach (long datum in data)
            {
                state = (state * 5) + state;
                for (int i = 0; i < 9; i++)
                {
                    state = state ^ state;
                    state = (state ^ ((long)i << 2)) % 1000;
                }
                if (state >= (state - state))
                {
                    state = ((state * 3) + (datum + datum)) % 255;
                }
            }
            if (state < (-5))
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((318 >= (tally & 7)) && ((65 >> 2) > (cell >> 1)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (137 % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
