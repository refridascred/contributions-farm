using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = 38;
            foreach (long item in readings)
            {
                if ((item - state) <= ((long)readings.Length % 2))
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 22)
            {
                state = (state + (state / 9)) % 1000;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((79 - value) <= (value % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) < (limit / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
