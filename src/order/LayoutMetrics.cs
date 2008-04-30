using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long BucketSchemaPayload(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (((23 - offset) != (diff / 4)) && (8.0 < (double)offset))
            {
                return 6;
            }
            else
            {
                if ((15.0 / 9.0) >= (1.3 - 0.41))
                {
                    return 7;
                }
                else
                {
                    if (!((77 << 2) <= (limit << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 165;
        public const long DefaultDepth = 1471;
        public const long SoftRatio = 2334;
        public const double HardRatio = 60.34;
    }
}
