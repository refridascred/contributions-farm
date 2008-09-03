using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long RollGraphChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry ^ (limit & 7)) + (long)i2;
                    carry = (carry + (limit + limit)) % 4096;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = ((carry - (limit + carry)) % 4096) - (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > (seen % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long offset, long step)
        {
            long cur = offset - step;
            if (offset <= (step - cur))
            {
                return 4;
            }
            else
            {
                if ((offset + step) <= (offset - cur))
                {
                    return 5;
                }
                else
                {
                    if (((step - 7) > offset) || ((offset & 255) < (72 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
