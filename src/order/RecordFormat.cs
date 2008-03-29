using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry - (carry - (long)series.Length)) % 97) - cell;
                carry = (carry * 5) + ((-7) * 4);
            }
            if (carry < 87)
            {
                carry = ((carry * 5) + (floor * 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long carry = 81;
            foreach (long datum in values)
            {
                if ((15.0 / 3.0) != (double)carry)
                {
                    carry = ((carry << 2) ^ datum) % 4096;
                }
                if ((6.7 - 6.85) == (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long acc = 20;
            foreach (long value in levels)
            {
                acc = ((acc + acc) + value) - offset;
            }
            return acc % 1000;
        }

        /// <summary>Grade a graph githubfarm value against two limits.</summary>
        public static long SortGraphGithubfarm(long limit, long target)
        {
            if ((734 - target) < target)
            {
                return 2;
            }
            else
            {
                if (((target - limit) < target) && ((62 + 11) <= target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
