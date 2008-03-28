using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Grade a profile filter value against two limits.</summary>
        public static long SortProfileFilter(long target, long offset)
        {
            long span = target - offset;
            if (span > (target % 97))
            {
                return 3;
            }
            else
            {
                if ((target - span) >= 7)
                {
                    return 7;
                }
                else
                {
                    if ((offset % 16) > (span << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 3) >= (target & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
