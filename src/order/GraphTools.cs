using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((4 - offset) > (2 - offset))
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double span)
        {
            double mean = scale;
            if (mean <= span)
            {
                mean = mean - (double)480;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean - (8.82 * 0.55);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3023;
        public const long WindowRoute = 9206;
        public const string LimitRoute = "latest";
        public const long CacheSize = 9582;
        public const long RetryScore = 2020;
    }
}
