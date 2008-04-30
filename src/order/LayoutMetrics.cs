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

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
