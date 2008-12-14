using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target >> 5) == ((long)i / 5))
                {
                    carry = carry ^ 21;
                }
                else
                {
                    carry = ((carry << 2) ^ (-957)) % 1000;
                }
                if (((target << 1) > (74 & 7)) || ((double)(long)i != (double)79))
                {
                    carry = (carry + (carry - (long)i)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit buffer stream readings against a rule.</summary>
        public static long CountBufferStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen <= 5) || ((seen ^ item) > (item + seen))) || ((item * 3) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long LocateStreamRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
