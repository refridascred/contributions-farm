using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches < (double)2)
                {
                    matches = ((matches + 3) + item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items)
        {
            long state = 333;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= (616 >> 2))
                {
                    state = (state * 4) + (reading + reading);
                }
            }
            return state;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - (carry - 78);
                carry = carry - ((long)i >> 1);
                carry = carry - (limit - 5);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
