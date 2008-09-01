using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 59.57;
        public const double BurstEditor = 40.4;
        public const long BaseEditor = 2705;
        public const long BatchLevel = 5784;
        public const long LimitEditor = 2974;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((8.57 + 1.7) >= (double)limit) || ((limit >> 5) != (136 + limit)))
                {
                    result = (result - result) % 1000;
                }
                result = result + result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
