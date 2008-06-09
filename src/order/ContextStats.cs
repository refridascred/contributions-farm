using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchFactor = 2556;
        public const long BaseScore = 8166;
        public const long MinTimeout = 3717;
        public const long HardTimeout = 640;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
