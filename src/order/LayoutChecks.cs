using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long origin)
        {
            long gap = target - origin;
            if (target > (232 * 5))
            {
                return 1;
            }
            else
            {
                if (!((gap * 5) >= ((-70) / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + 41) > (gap - gap))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(origin >= (gap + 9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((origin & 3) > (item - item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchRatio = 2.61;
        public const long HardTools = 137;
        public const long DefaultTools = 7950;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long carry = 63;
            foreach (long cell in values)
            {
                carry = (((carry << 3) ^ (target % 12)) % 255) ^ cell;
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry >> 3)) % 255;
            }
            return carry % 97;
        }
    }
}
