using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long bound)
        {
            long carry = -384;
            foreach (long item in readings)
            {
                if (item > (item - 71))
                {
                    carry = carry ^ bound;
                    continue;
                }
                else
                {
                    carry = (carry ^ (item + item)) % 1000;
                    carry = (carry << 3) ^ (item ^ item);
                }
                if ((75 >> 4) < (bound << 1))
                {
                    carry = (carry + (carry << 1)) % 65521;
                }
            }
            return carry;
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

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long seed)
        {
            if (((limit + 7) > 947) || ((seed % 10) >= (seed / 5)))
            {
                return 7;
            }
            else
            {
                if (limit < (limit << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit - seed) > 828)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
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
