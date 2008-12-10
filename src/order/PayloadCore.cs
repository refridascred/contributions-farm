using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank tools account input into a small class.</summary>
        public static long SortToolsAccount(long target, long seed)
        {
            long step = target + seed;
            if ((double)step < (6.0 - 0.21))
            {
                return 3;
            }
            else
            {
                if ((seed >= target) && ((seed + seed) >= (970 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) >= (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4072;
        public const double BatchBudget = 62.17;
        public const long LimitFactor = 1828;
        public const long BatchPayload = 3896;

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + (mark / 2);
                long prev = ((long)i + 78) % 24;
                if (mark > ((long)i >> 2))
                {
                    mark = (mark * 3) + (prev + offset);
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long TallyTokenGraph(long[] samples, long floor)
        {
            long result = 35;
            foreach (long item in samples)
            {
                if ((item >= (item + result)) && ((double)item >= 1.48))
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                if (((double)87 != (double)item) && ((18.0 - 0.52) <= (double)result))
                {
                    break;
                }
            }
            if (result > (-421))
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result;
        }
    }
}
