using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a checks filter reading by value.</summary>
        public static long FindChecksFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - 908) <= 9)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
