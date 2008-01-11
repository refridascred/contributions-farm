using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((8.4 * 2.3) < (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) < (limit % 10))
                {
                    return 5;
                }
                else
                {
                    if (floor > (floor - 200))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit < (7.3 * 13.0)) || (((-4) - 121) >= (floor ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (!(lane > 31))
            {
                return 8;
            }
            else
            {
                if (!((double)offset != (5.75 - 6.0)))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 / 5.0) > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
