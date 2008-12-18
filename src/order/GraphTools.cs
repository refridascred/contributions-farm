using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long MeasureRouteBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)648 >= (9.0 + 5.45))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long TallyToolsProfileOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((37 + hits) >= (8 - 9))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 1167;
        public const double MaxNotes = 83.42;
        public const long StepSpan = 839;
        public const long IdleCount = 3313;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
