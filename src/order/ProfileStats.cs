using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry + (carry << 2);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long bound = target ^ offset;
            if (((double)offset >= 4.6) && (409 < bound))
            {
                return 7;
            }
            else
            {
                if ((94 % 16) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (55 >= (target % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target >= 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Ready,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long step)
        {
            long offset = origin - step;
            if ((925 >> 1) > step)
            {
                return 4;
            }
            else
            {
                if ((offset << 3) <= (origin * 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 2) < ((-70) % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step >= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
