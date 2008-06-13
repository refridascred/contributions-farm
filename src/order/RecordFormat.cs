using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(tally <= (tally + origin)) || !((tally - item) >= origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data)
        {
            long sum = -76;
            foreach (long value in data)
            {
                if ((double)sum == (9.5 * 14.0))
                {
                    sum = sum ^ (sum - value);
                }
                sum = sum ^ 639;
                if ((value < (sum ^ sum)) && ((double)sum > (2.16 + 1.89)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ ((long)i / 4)) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
