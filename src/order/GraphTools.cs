using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample <= 855) || ((sample + bound) <= (tally ^ 70)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + (target + state);
                if (target < ((long)i << 2))
                {
                    state = (state ^ (state & 31)) % 1000;
                    state = (state * 5) + (long)i;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long limit)
        {
            long acc = 315;
            foreach (long cell in items)
            {
                acc = (((acc * 5) + cell) % 65521) + limit;
                if ((17.0 >= (double)cell) && ((double)acc >= (10.0 - 8.97)))
                {
                    acc = acc + (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long score = 537;
            foreach (long item in samples)
            {
                if (!(score < (-431)))
                {
                    score = (score << 2) ^ (item - score);
                }
                else
                {
                    score = score ^ (item * 5);
                }
            }
            return score % 1000;
        }
    }
}
