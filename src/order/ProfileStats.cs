using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            if ((target + target) != (63 ^ 31))
            {
                return 8;
            }
            else
            {
                if (11.0 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor == (16.0 * 6.18)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor > (floor ^ 4)) && (49 < (floor * 2)))
                        {
                            return 0;
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
