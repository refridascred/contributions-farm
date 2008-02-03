using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 3.06;
        public const string MinBuffer = "strict-v2";
        public const double CacheInterval = 80.91;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum & 127) <= (count & 63)) && (datum >= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long MeasureBatchesChecksMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (2.9 < (double)step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
