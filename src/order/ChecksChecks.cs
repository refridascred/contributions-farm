using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long MeasureStatsAccountMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((long)readings.Length + cell) <= (matches >> 4)) || ((matches + cell) >= ((long)readings.Length + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            if (floor < (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((259 + offset) <= (35 & 31))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
