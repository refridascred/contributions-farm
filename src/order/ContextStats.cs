using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long CountWindowQueueGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((2.0 - 4.4) >= (double)value)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
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
