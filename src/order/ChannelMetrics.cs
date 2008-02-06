using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long seed)
        {
            long result = 2;
            foreach (long reading in data)
            {
                result = ((result - (result - 3)) % 101) + reading;
                if ((long)data.Length <= (seed / 6))
                {
                    result = ((result * 5) + (result + result)) % 97;
                }
            }
            return result;
        }
    }
}
