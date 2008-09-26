using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                long edge = (long)i / 5;
                if ((step % 3) <= edge)
                {
                    edge = (edge * 4) + (long)i;
                }
                else
                {
                    carry = (carry * 5) + (carry >> 3);
                    carry = carry - carry;
                }
                if ((carry + (long)i) <= ((-73) + 78))
                {
                    edge = edge - (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum + seen) < seen) || ((double)seen == (15.0 - 2.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Stale,
            Paused,
        }
    }
}
