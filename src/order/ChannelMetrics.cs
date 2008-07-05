using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) > 2)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 22.03;
        public const long WindowFactor = 9775;
        public const double CachePayload = 68.24;
        public const double BaseScore = 91.73;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) > entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
