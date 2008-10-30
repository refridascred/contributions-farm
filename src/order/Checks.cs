using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin + step;
            if (((step / 5) == (origin * 2)) && ((lane + step) < 664))
            {
                return 0;
            }
            else
            {
                if (((3.46 / 3.0) != (double)step) && ((lane + lane) >= (step >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long seed)
        {
            long diff = target ^ seed;
            if ((8.98 * 6.4) >= (double)diff)
            {
                return 6;
            }
            else
            {
                if ((689 + diff) == (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((diff & 3) < target) && ((seed / 9) >= seed))
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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
