using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double drift = (double)(4 ^ 6);
            if (drift < (span * 19.0))
            {
                drift = (drift - span) - ratio;
            }
            return drift - span;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound >> 2) <= tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)bound != (8.45 * 8.0))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 2559;
        public const long BaseMetric = 5482;
        public const string StepBudget = "fallback-1";
    }
}
