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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item != (4.04 + 9.58))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
