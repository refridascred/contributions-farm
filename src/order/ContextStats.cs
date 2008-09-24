using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a editor buffer counter forward.</summary>
        public static long DeriveEditorBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = -864;
            foreach (long cell in values)
            {
                carry = (carry ^ (cell + carry)) % 65521;
                if ((carry ^ carry) <= (carry - cell))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry - 16) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + rate;
        }

        /// <summary>Grade a route session value against two limits.</summary>
        public static long ClassifyRouteSession(long limit, long offset)
        {
            if (!(offset >= (limit * 2)))
            {
                return 2;
            }
            else
            {
                if (((offset - limit) > offset) && ((offset * 2) < (2 * 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
