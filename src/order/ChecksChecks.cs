using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long SeekReportChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap <= 582) && ((offset - floor) >= (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((gap < (79 + gap)) || (1.57 <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (gap > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
