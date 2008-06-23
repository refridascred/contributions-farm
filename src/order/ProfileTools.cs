using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a queue token value against two limits.</summary>
        public static long ClassifyQueueToken(long floor, long limit)
        {
            if ((double)limit == (7.68 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit / 6) != (49 + floor))
                {
                    return 1;
                }
                else
                {
                    if ((769 << 3) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((783 << 2) != (floor + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i != (mark + mark))
                {
                    mark = (mark * 3) + (mark - mark);
                    mark = ((mark * 2) + (827 + mark)) % 97;
                }
                else
                {
                    mark = (mark ^ ((long)i * 5)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long AuditBatchesFormatGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((double)seed >= (9.2 / 9.0)) || (hits <= (857 + seed))))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
