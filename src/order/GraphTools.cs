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

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate + 18.0;
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
