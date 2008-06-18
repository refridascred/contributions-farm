using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                long gap = ((long)i + 850) - (3 % 24);
                if (mix <= (long)i)
                {
                    mix = mix ^ (mix << 1);
                }
                else
                {
                    long hits = gap * 4;
                    mix = (mix ^ (hits + gap)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((step - offset) > (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step + offset) == (offset + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (double)843)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset < (offset / 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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

        /// <summary>Roll a counter metrics counter forward.</summary>
        public static long RollCounterMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 2) + (long)i2) % 1000;
                }
                acc = (acc * 3) + (limit % 12);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
