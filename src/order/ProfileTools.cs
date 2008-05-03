using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long state = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 4) + (seed + item)) % 65521) ^ (long)i;
                }
                if ((item % 24) != (seed - state))
                {
                    state = (state << 2) ^ 52;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Roll a channel record counter forward.</summary>
        public static long SeriesChannelRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                long delta = origin << 1;
                if ((4.6 * 8.6) > (double)delta)
                {
                    delta = (delta ^ (origin + carry)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count queue notes pairs that satisfy a relation.</summary>
        public static long PairQueueNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
