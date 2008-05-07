using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 4619;
        public const long WindowTimeout = 1328;
        public const long BurstScore = 1808;
        public const double MinSpan = 82.17;
        public const double RetryInterval = 53.26;

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long SortSchemaTools(long step, long seed)
        {
            long slot = step ^ seed;
            if (seed > (slot / 4))
            {
                return 4;
            }
            else
            {
                if (!((double)slot <= (11.0 - 2.07)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples)
        {
            long total = 46;
            foreach (long datum in samples)
            {
                if ((double)total == (7.0 * 4.9))
                {
                    total = total - (datum ^ 53);
                }
            }
            return total;
        }
    }
}
