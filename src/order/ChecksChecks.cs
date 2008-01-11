using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long seed)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (state + (state >> 2)) - sample;
            }
            if (state < 505)
            {
                state = (state << 3) ^ seed;
            }
            return state % 4096;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command batch samples are out of range.</summary>
        public static long MeasureCommandBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (95 <= sample)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
