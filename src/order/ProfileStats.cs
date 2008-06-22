using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long GradeToolsWindow(long step, long limit)
        {
            if ((step < (step + limit)) || ((2 + 467) < (9 ^ step)))
            {
                return 4;
            }
            else
            {
                if (5.52 >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (!((step / 9) > (limit % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit - limit)) && ((874 & 255) > limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long TallyCounterRoute(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + (value + 847)) - (long)i;
                }
                if ((double)carry != (18.0 / 5.0))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            if (carry < (-48))
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((2.69 * 8.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ reading) + seed;
                }
            }
            return seen;
        }
    }
}
