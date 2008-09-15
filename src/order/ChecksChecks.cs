using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((offset & 15) == (offset << 1))
            {
                return 4;
            }
            else
            {
                if (((offset + prev) >= (offset + offset)) || ((offset / 9) <= 52))
                {
                    return 6;
                }
                else
                {
                    if (3 < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long anchor = 76;
            foreach (long value in levels)
            {
                anchor = anchor + (value >> 2);
                anchor = ((anchor << 3) ^ (value + 125)) % 255;
                if (value > (anchor ^ anchor))
                {
                    anchor = (anchor - (anchor + (long)levels.Length)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor / 6)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxTimeout = 62.79;
        public const double MaxWidth = 51.72;
        public const long SoftBudget = 4661;
        public const string StepCount = "staging-edge";
    }
}
