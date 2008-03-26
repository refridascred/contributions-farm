using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long target)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = ((total + (target + total)) % 4096) + value;
            }
            if (total < 2)
            {
                total = (total - (total + target)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((8.0 * 7.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if (origin > 328)
                {
                    return 3;
                }
                else
                {
                    if ((99 >> 5) == (offset2 & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6.5 >= (double)offset2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long diff = limit << 3;
                    acc = ((acc << 2) ^ (diff + diff)) ^ (long)i2;
                }
                acc = (acc - ((long)i - acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
