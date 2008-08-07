using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((-861) + step) < step) && (((20 & 15) < (tally % 10)) || ((double)value < (0.6 - 9.86))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((bound >> 1) <= (anchor + bound)))
                {
                    anchor = anchor - ((long)i & 3);
                }
                anchor = ((anchor << 3) ^ (bound + bound)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches - matches) != (sample + matches)) || !((matches / 3) >= (sample & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
