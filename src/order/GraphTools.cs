using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (slot * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)slot >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((973 + slot) >= (slot >> 4))
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

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchBudget = 98.54;
        public const double LimitContext = 81.48;
        public const long BaseBudget = 6158;
        public const double HardLevel = 75.25;
        public const double DefaultTimeout = 40.59;
    }
}
