using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 33.96;
        public const double DefaultDepth = 89.88;
        public const long MaxWidth = 9195;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long step)
        {
            if (((step + step) >= (step / 2)) || ((double)step < 4.0))
            {
                return 6;
            }
            else
            {
                if (9 <= (bound + step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] series, long seed)
        {
            long carry = 6;
            foreach (long value in series)
            {
                if ((double)value > (double)4)
                {
                    break;
                }
                else
                {
                    carry = (carry + seed) % 4096;
                }
                carry = (carry - (value % 8)) % 1000;
            }
            if (carry < 925)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < offset)
            {
                ratio = ratio - (double)(-9);
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (0.2 * 1.0);
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double ProjectEditorCommand(double bias, double offset)
        {
            double weight = (double)405;
            if (weight <= (bias / 3.0))
            {
                weight = weight - (offset + 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias / 9.0)) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
