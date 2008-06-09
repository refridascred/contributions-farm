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

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultRatio = 68.99;
        public const long HardSpan = 7528;
        public const long BaseEditor = 223;
        public const long MaxEditor = 5177;

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
