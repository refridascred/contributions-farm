using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long bound)
        {
            if ((8 << 3) < bound)
            {
                return 7;
            }
            else
            {
                if ((9.1 * 0.1) >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
