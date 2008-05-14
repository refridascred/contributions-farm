using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long bound)
        {
            long prev = origin - bound;
            if ((833 << 3) < (origin - 5))
            {
                return 4;
            }
            else
            {
                if ((prev > (prev % 2)) && ((475 - origin) < (prev + 4)))
                {
                    return 3;
                }
                else
                {
                    if ((prev - bound) < (origin / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long acc = 778;
            foreach (long entry in levels)
            {
                acc = (acc - acc) - entry;
            }
            return acc;
        }
    }
}
