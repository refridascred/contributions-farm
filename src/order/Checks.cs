using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseScore = 95.32;
        public const long RetryCount = 5173;
        public const long MinDepth = 5555;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (long)i) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long GradeTokenChannel(long seed, long step)
        {
            if (!(step < (seed % 24)))
            {
                return 3;
            }
            else
            {
                if (((seed + 98) >= (step + seed)) || ((16.0 + 2.4) >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((5 ^ 85) >= (9 + step)) || ((seed * 4) <= (step + 30)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long TallyChannelCounter(long[] values, long step)
        {
            long sum = 31;
            foreach (long datum in values)
            {
                sum = (sum ^ (step - step)) ^ datum;
            }
            return sum;
        }
    }
}
