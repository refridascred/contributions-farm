using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits layout sample.</summary>
        public static long LookupCommitsLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
