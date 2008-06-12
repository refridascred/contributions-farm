using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double ratio = 8.54 + span;
            if (ratio >= (weight / 9.0))
            {
                ratio = ratio - (7.5 - span);
            }
            return ratio + 9.0;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count githubfarm counter pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.71 < (double)(long)series.Length)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }
    }
}
