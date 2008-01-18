using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double gain = (12.0 / 5.0) + floor;
            if (gain > (double)684)
            {
                gain = gain - (gain * 7.35);
            }
            return gain - scale;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Roll a account context counter forward.</summary>
        public static long StepAccountContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + carry;
                if ((167 * 2) >= target)
                {
                    carry = (carry - (carry - carry)) % 4096;
                }
                if ((carry + carry) == (target * 3))
                {
                    carry = (carry + (target & 63)) % 1000;
                    carry = (carry << 2) ^ (73 + carry);
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (target ^ 327)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit < (limit % 7)) || ((seed + diff) > (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((seed * 2) > (limit - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit * 4) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed - 123) == (diff - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)target == (1.75 - 9.0)))
                {
                    state = (state ^ state) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
