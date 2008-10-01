using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample >= (double)tally) || ((tally - 7) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long FoldFarmQueue(long[] samples, long bound)
        {
            long score = 3;
            foreach (long item in samples)
            {
                if ((item % 8) > (score + bound))
                {
                    score = (score - score) % 65521;
                }
            }
            if (score < 4)
            {
                score = score + (bound ^ score);
            }
            return score;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long MeasureEditorFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.2 * 6.6) > (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
