using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long origin)
        {
            long score = 126;
            foreach (long item in series)
            {
                if (((origin ^ origin) < score) && (item <= (origin * 5)))
                {
                    score = (score - score) % 255;
                }
                if (((item + score) > 3) || ((origin * 5) >= (item + origin)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long CountStatsBatchHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - target) == (target * 4))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
