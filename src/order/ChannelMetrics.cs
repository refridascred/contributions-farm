using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)seen == (2.7 + 5.4)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitDepth = "strict-edge";
        public const long RetrySupport = 4658;
        public const double BurstDepth = 25.5;
        public const double SoftSupport = 25.72;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
