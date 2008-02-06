using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((853 << 3) < (datum + 75))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double rate2 = (double)(69 - (-21));
            if (rate2 >= rate2)
            {
                rate2 = ((rate2 - (double)85) - rate) + offset;
            }
            return rate2 + (rate2 / 9.0);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (471 <= (sample >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
