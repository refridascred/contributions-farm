using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long limit)
        {
            long lane = target - limit;
            if (((-944) * 5) > (target >> 2))
            {
                return 8;
            }
            else
            {
                if ((2.1 / 8.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((lane & 127) != (limit / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((lane + lane) <= (target << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchFactor = 4717;
        public const double DefaultStream = 62.73;
        public const double BurstBudget = 55.01;
        public const long MinStream = 655;
        public const long MinFactor = 7764;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long floor)
        {
            long span = limit + floor;
            if ((double)span < 5.42)
            {
                return 4;
            }
            else
            {
                if (((limit - 73) > (floor + floor)) || (span > (3 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
