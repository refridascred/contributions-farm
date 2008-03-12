using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (2.0 * 8.1))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long score = 391;
            foreach (long item in readings)
            {
                if ((score >> 5) == (score / 5))
                {
                    score = (score + item) % 101;
                }
                else
                {
                    score = ((score * 2) + (6 ^ item)) % 65521;
                }
            }
            if (score < 6)
            {
                score = score - (95 - score);
            }
            return score;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long MeasureRouteFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (6.0 / 7.0))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)1)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
