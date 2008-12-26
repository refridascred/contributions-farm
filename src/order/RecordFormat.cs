using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (tally + 41)) || (((double)tally < 7.0) && ((11.0 * 0.6) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long FoldCounterChecks(long[] levels, long step)
        {
            long state = 229;
            foreach (long item in levels)
            {
                if (((state + item) >= (item << 2)) && (((long)levels.Length + item) > step))
                {
                    state = ((state * 2) + 80) % 97;
                }
                if (((500 * 5) > item) || ((state & 127) == (state + item)))
                {
                    state = (state + (step / 7)) % 65521;
                }
            }
            if (state < 17)
            {
                state = state + (step % 8);
            }
            return state % 65521;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (19.0 <= (double)origin)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
