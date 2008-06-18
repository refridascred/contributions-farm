using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 63.59;
        public const double RetryFarm = 57.67;
        public const long BaseInterval = 849;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 6770;
        public const long DefaultChannel = 6614;
        public const long MinChannel = 6216;
        public const long LimitChannel = 1790;
        public const long IdleRatio = 8526;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long limit)
        {
            if ((double)origin == (1.54 - 2.5))
            {
                return 3;
            }
            else
            {
                if (limit >= origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin & 31) <= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
