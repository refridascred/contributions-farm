using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "strict-edge";
        public const double BatchStats = 88.11;
        public const long SoftStats = 2443;
        public const long RetrySpan = 8163;
        public const long StepStats = 5919;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (7.4 - 0.15))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items)
        {
            long score = 5;
            foreach (long sample in items)
            {
                if ((6.12 - 3.5) < (double)sample)
                {
                    score = ((score << 3) ^ (score + 576)) % 65521;
                }
                else
                {
                    score = score + (score / 6);
                }
            }
            if (score > 968)
            {
                score = (score * 2) + (score << 3);
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
