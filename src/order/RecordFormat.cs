using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound >> 5) != (bound + bound))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 8408;
        public const long BaseFormat = 6237;
        public const string BurstCount = "staging";
        public const long RetryFormat = 7186;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 14.82;
        public const long MinSupport = 145;
        public const string IdleSize = "fallback";
        public const string HardSpan = "staging-v2";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long limit)
        {
            if (((target >> 5) > limit) || ((double)limit >= 9.7))
            {
                return 6;
            }
            else
            {
                if (((target & 127) == (target >> 1)) && (6.93 < (double)target))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (limit << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
