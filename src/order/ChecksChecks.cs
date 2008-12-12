using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long CountGraphSupportMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor + floor) >= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length < matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long bound)
        {
            long state = 51;
            foreach (long value in items)
            {
                if (value >= (-71))
                {
                    state = (state ^ state) + bound;
                    break;
                }
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
