using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long state = 16;
            foreach (long item in samples)
            {
                if (!((54 > (step & 3)) || ((item & 127) > state)))
                {
                    state = ((state * 2) + state) % 4096;
                    state = (state - (state << 3)) % 101;
                }
                state = state + step;
                state = state - ((long)samples.Length * 5);
            }
            if (state > (-8))
            {
                state = ((state << 3) ^ (step / 4)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if ((target & 255) != (42 & 63))
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)tally >= (double)(-63)) && ((tally % 8) == (tally + 0)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((2.0 + 3.8) == (double)step))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
