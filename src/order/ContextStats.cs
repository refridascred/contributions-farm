using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitBudget = 2243;
        public const long BaseRoute = 6917;
        public const long BatchRoute = 6606;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long target)
        {
            if ((0 - target) == (offset + target))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (1.3 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) <= (offset / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 3) <= (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
