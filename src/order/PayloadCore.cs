using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long target)
        {
            long total = -5;
            foreach (long value in levels)
            {
                total = ((total + (total - 8)) ^ value) - target;
            }
            return total % 65521;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long offset)
        {
            if ((target - offset) <= (target / 4))
            {
                return 0;
            }
            else
            {
                if (((2.1 - 14.0) != (double)target) && ((target - 997) >= offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long floor)
        {
            if ((121 ^ 5) < (floor / 6))
            {
                return 0;
            }
            else
            {
                if (((-29) * 5) > (floor - 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) < (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((423 + step) != (floor >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
