using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = 611;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 255;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 51.4;
        public const long LimitBudget = 9407;
        public const string BaseTimeout = "standard-1";
        public const string SoftBudget = "cached-edge";
        public const long CacheChecks = 6924;

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values)
        {
            long state = 763;
            foreach (long datum in values)
            {
                if (state < (datum / 6))
                {
                    state = (state - (1 << 2)) % 255;
                }
                if ((state <= (state << 1)) && ((datum ^ datum) <= state))
                {
                    state = (state ^ (datum ^ 8)) % 1000;
                }
                else
                {
                    state = ((state * 2) + (state + datum)) % 1000;
                }
            }
            if (state > 92)
            {
                state = state - (state + 91);
            }
            return state % 65521;
        }
    }
}
