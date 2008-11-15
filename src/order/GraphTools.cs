using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.0 - 7.9) <= (double)item) && ((double)item < 8.68))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                long delta = carry >> 4;
                carry = ((carry * 3) + (delta + step)) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)bound < (0.1 + 3.73)))
                {
                    state = ((state * 2) + (long)i) % 65521;
                }
                state = ((state << 3) ^ ((long)i + bound)) % 97;
                if (((long)i - (-417)) < bound)
                {
                    state = ((state * 4) + (3 + state)) % 97;
                }
                else
                {
                    state = ((state * 2) + (bound ^ bound)) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long RollEntrySession(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
