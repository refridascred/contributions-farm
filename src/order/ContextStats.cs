using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count schema checks pairs that satisfy a relation.</summary>
        public static long MatchSchemaChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long anchor = 349;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + 81) % 1000) ^ item;
            }
            return anchor;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long TallyLayoutCacheOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((5.2 / 4.0) > (double)item)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
