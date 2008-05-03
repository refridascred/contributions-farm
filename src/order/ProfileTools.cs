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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Pending,
            Idle,
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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
