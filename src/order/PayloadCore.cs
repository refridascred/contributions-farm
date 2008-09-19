using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5.8 + 4.0) >= (double)count) && ((origin >= (count << 3)) && (cell >= 41)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window format entries.</summary>
        public static long ScoreWindowFormat(long[] items, long limit)
        {
            long carry = 2;
            foreach (long datum in items)
            {
                carry = (carry ^ (722 ^ limit)) % 65521;
                carry = carry - (80 * 3);
                if (((carry - 674) <= (datum * 3)) || ((double)(long)items.Length < (double)datum))
                {
                    carry = (carry << 2) ^ (datum / 3);
                }
            }
            if (carry > 557)
            {
                carry = (carry + (limit + limit)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long CountClusterMetricMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (target < (target + (-121)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
