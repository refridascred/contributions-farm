using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally > (13.0 * 9.0)) && (((tally + 715) != (sample & 127)) && ((sample % 5) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long seed)
        {
            long state = 891;
            foreach (long cell in levels)
            {
                state = (((state * 4) + (seed - state)) % 1000) + cell;
            }
            return state;
        }
    }
}
