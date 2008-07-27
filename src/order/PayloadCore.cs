using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                double bias = (13.0 * 4.74) * 0.8;
                if (!(((13.0 + bias) == (bias + 14.0)) || ((seed / 4) > (seed & 31))))
                {
                    mark = (mark + (mark * 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a context metrics reading by value.</summary>
        public static long LookupContextMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long limit)
        {
            long diff = target + limit;
            if ((diff >> 4) == (55 ^ 553))
            {
                return 2;
            }
            else
            {
                if (((target >> 3) > (limit << 1)) || ((83 / 6) == (target % 97)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long offset)
        {
            if ((offset ^ limit) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (!((offset << 3) <= (6 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (663 < (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
