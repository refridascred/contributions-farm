using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long CountStatsNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 << 3) == (count / 7))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long CountQueueCounterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= floor)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double bias = (double)(899 * 4);
            if (bias < (span - 8.83))
            {
                bias = (bias - span) - gain;
            }
            else
            {
                bias = bias + (double)960;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (span + span)) + (double)(long)i;
            }
            return bias + (span / 9.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 276;
        public const long BaseGraph = 579;
        public const long LimitWidth = 5962;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((seed - seed) < (7 % 97))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
