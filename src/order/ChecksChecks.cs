using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 664;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 1000) - cell;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long state = 31;
            foreach (long reading in samples)
            {
                if (target > (state + 3))
                {
                    state = (state - target) ^ reading;
                }
                if ((double)state > 16.0)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ ((long)i + (long)i);
                if ((anchor >> 1) < (anchor % 64))
                {
                    long bound = anchor;
                    anchor = (anchor + (650 + bound)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
