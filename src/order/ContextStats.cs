using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count report cache pairs that satisfy a relation.</summary>
        public static long CompareReportCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score + step;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = score - (step + (long)i2);
                    score = ((score * 4) + ((-466) * 5)) % 4096;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue filter readings against a rule.</summary>
        public static long MeasureQueueFilterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (12.0 >= (double)seen)
                {
                    seen = ((seen + 1) + sample) + origin;
                }
            }
            return seen;
        }
    }
}
