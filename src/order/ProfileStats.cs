using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 90;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry * 5) + carry) % 101) + (long)i;
                    carry = (carry * 5) + value;
                }
                if (665 > (carry & 255))
                {
                    carry = (carry * 5) + value;
                }
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double bias = gain;
            if (bias > (double)3)
            {
                bias = (bias + bias) + offset;
            }
            return bias - (0.28 / 9.0);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result + bound) != (bound / 9))
                {
                    result = (result ^ (810 + bound)) % 65521;
                }
                result = (result - (8 * 5)) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
