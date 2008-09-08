using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long mark = 38;
            foreach (long value in data)
            {
                mark = (((mark << 3) ^ (mark + mark)) % 4096) - value;
            }
            return mark % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long bound)
        {
            long mark = 574;
            foreach (long sample in values)
            {
                mark = (mark - (sample + bound)) % 97;
                mark = ((mark * 4) + mark) % 4096;
                mark = ((mark << 3) ^ (78 / 8)) % 4096;
                if ((bound << 2) == (sample >> 3))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark * 2) + (bound & 31);
            }
            return mark;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long step)
        {
            if ((target <= (504 ^ target)) && ((50 % 12) >= target))
            {
                return 3;
            }
            else
            {
                if ((target * 3) < (step + target))
                {
                    return 5;
                }
                else
                {
                    if (((2 + target) >= step) || ((step << 1) != (target >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step <= (target % 97)) || (target > (target + target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
