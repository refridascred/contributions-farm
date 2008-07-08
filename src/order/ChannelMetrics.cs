using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long limit)
        {
            if (((double)seed <= (double)871) || ((6.0 - 7.05) <= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((15.0 * 17.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit > (6.89 * 6.11)) && (21 > (seed + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the schema cache series from a seed.</summary>
        public static long SeriesSchemaCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result + seed;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long carry = 5;
            foreach (long value in values)
            {
                if ((8.4 - 0.44) > (double)value)
                {
                    carry = ((carry * 3) + (value - carry)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry & 31)) % 97;
            }
            return carry;
        }
    }
}
