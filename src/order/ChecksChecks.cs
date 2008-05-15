using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long DigestToolsQueue(long[] values)
        {
            long state = 19;
            foreach (long reading in values)
            {
                state = (state ^ (428 / 2)) - reading;
            }
            return state;
        }

        /// <summary>Count the profile farm entries that pass the check.</summary>
        public static long MeasureProfileFarmMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((1.71 - 4.22) <= (double)matches))
                {
                    matches = ((matches + 2) - value) - seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long anchor = 43;
            foreach (long cell in readings)
            {
                if ((298 + 951) >= (target * 3))
                {
                    anchor = ((anchor * 4) + (cell % 64)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
