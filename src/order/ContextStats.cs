using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many checks metric samples are out of range.</summary>
        public static long TallyChecksMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) == (entry % 24))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long ScoreBatchesSchema(long[] samples, long step)
        {
            long total = 395;
            foreach (long cell in samples)
            {
                if (step >= (cell - total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = ((total * 2) + (step & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
