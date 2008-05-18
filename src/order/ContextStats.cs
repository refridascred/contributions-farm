using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long limit, long offset)
        {
            long span = limit - offset;
            if ((749 >= (span + offset)) || (limit >= offset))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= 4.2) && ((845 << 3) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (limit > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span / 6) != (span + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 7.91;
        public const long LimitNotes = 7076;
        public const long BaseNotes = 1032;
        public const long BurstNotes = 4983;
    }
}
