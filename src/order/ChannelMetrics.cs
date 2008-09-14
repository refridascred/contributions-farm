using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] items)
        {
            long result = 222;
            foreach (long datum in items)
            {
                result = (result - (datum + datum)) % 97;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 7578;
        public const double SoftFilter = 37.8;
        public const double LimitFilter = 57.82;
        public const long MaxFilter = 8565;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
