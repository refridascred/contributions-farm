using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = gain + offset;
            if (weight > (gain * 11.0))
            {
                weight = weight - (gain - offset);
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (offset * 5.27)) + (double)(long)i;
            }
            return weight + 6.9;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) == (seen / 5)) && ((9 % 97) <= seen))
                {
                    seen = ((seen + 2) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long SortTokenPayload(long limit, long floor)
        {
            if ((floor * 2) < (floor + limit))
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 1) == (limit & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit % 16) < (0 ^ limit)) || ((limit + floor) >= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
