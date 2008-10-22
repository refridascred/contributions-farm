using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((bound / 2) <= bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 & 1) > bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound - offset) > (-6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((415 % 100) != (offset ^ offset)) && ((bound * 2) > offset))
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
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7487;
        public const long LimitScore = 7988;
        public const long MinSchema = 959;
        public const long LimitSchema = 704;
        public const string RetrySpan = "alpha-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 50;
            foreach (long datum in items)
            {
                state = ((state ^ (state << 2)) % 97) - datum;
            }
            if (state < 32)
            {
                state = (state << 3) ^ state;
            }
            return state % 97;
        }
    }
}
