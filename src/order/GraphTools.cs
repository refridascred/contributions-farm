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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
