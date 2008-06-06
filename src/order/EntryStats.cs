using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long count = 6 + sum;
                if ((count >> 5) >= count)
                {
                    count = ((count << 2) ^ (75 % 16)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long origin)
        {
            long offset = target + origin;
            if ((409 / 8) <= origin)
            {
                return 1;
            }
            else
            {
                if (offset < origin)
                {
                    return 8;
                }
                else
                {
                    if ((10.0 - 1.4) != (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "cached";
        public const long DefaultEditor = 6395;
        public const string BurstCount = "primary-edge";

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long limit)
        {
            long bound = floor - limit;
            if ((925 << 1) != (limit >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < (bound ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) >= (floor & 3)) || ((bound >> 5) < (-587)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
