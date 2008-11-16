using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9242;
        public const double StepLevel = 5.13;
        public const double IdleRatio = 59.24;
        public const long MinAlready = 3557;

        /// <summary>Blend two graph farm measurements.</summary>
        public static double BlendGraphFarm(double rate, double offset)
        {
            double scale = (double)(627 >> 2);
            if (scale > scale)
            {
                scale = (scale - 0.97) - rate;
            }
            else
            {
                scale = scale - (offset * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (double)559;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long floor)
        {
            if ((origin & 255) < (origin ^ floor))
            {
                return 5;
            }
            else
            {
                if ((double)6 != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if (((entry * 5) != (entry >> 2)) || ((double)carry == (9.0 - 9.0)))
                {
                    carry = carry - 1;
                }
                if ((entry >> 4) <= (entry + carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }
    }
}
