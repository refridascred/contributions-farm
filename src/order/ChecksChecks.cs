using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long step)
        {
            if (!((step + bound) != (bound / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)step == (2.8 + 3.0))
                {
                    return 7;
                }
                else
                {
                    if (((-346) / 8) == (bound + 61))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound & 31) == (bound & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                long offset2 = ((long)i ^ (long)i) >> 2;
                carry = carry ^ (offset2 & 255);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a already record counter forward.</summary>
        public static long SeriesAlreadyRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
