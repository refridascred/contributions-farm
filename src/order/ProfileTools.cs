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

        /// <summary>Find the first filter schema entry that matches the target.</summary>
        public static long LocateFilterSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
