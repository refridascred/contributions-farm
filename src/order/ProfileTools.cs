using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long StepReportChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i + (long)i))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 1000;
                    state = (state * 5) + (971 + target);
                }
                else
                {
                    state = state ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(839 < (cell << 1)))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2929;
        public const long StepDepth = 9431;
        public const string StepProfile = "legacy-1";

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long CountBatchFormatHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target + tally) < (sample % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
