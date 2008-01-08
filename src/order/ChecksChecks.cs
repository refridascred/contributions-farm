using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long next = target + step;
            if ((next - target) <= step)
            {
                return 0;
            }
            else
            {
                if ((target - target) < (next - next))
                {
                    return 5;
                }
                else
                {
                    if ((0.14 - 3.05) <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((58 - 92) <= (target + 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if (!(0.31 < (double)reading))
                {
                    carry = (carry << 3) ^ reading;
                }
                carry = carry + (bound - 0);
                if ((71 & 31) > bound)
                {
                    carry = carry - reading;
                }
            }
            if (carry > 55)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                if (47 < ((-643) ^ mix))
                {
                    mix = mix ^ offset;
                }
                mix = ((mix << 2) ^ (long)i) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
