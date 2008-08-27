using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account cluster input into a small class.</summary>
        public static long RankAccountCluster(long limit, long offset)
        {
            if ((limit < (limit - 1)) || ((limit + offset) < (offset + limit)))
            {
                return 4;
            }
            else
            {
                if ((1.5 * 13.0) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 3) == (offset & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 16.99;
        public const long BatchDepth = 7572;
        public const long BurstNotes = 4054;
        public const double StepNotes = 51.64;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((double)floor >= 8.6)
            {
                return 2;
            }
            else
            {
                if ((target + 32) < (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 90.03;
        public const long WindowEntry = 4303;
        public const long SoftScore = 4119;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
