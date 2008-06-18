using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a filter payload counter forward.</summary>
        public static long IterateFilterPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ acc) % 101;
                if ((target < ((long)i + (long)i)) && ((target / 7) <= (acc * 2)))
                {
                    acc = ((acc << 3) ^ ((long)i + target)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long step2)
        {
            long step3 = step - step2;
            if ((step3 + step) >= (step / 5))
            {
                return 1;
            }
            else
            {
                if ((double)step > (19.0 / 9.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (reading / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long state = 5;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ state) - datum;
            }
            if (state < 191)
            {
                state = state + (state << 3);
            }
            return state % 1000;
        }
    }
}
