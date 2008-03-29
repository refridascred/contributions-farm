using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate entry tools samples.</summary>
        public static long TallyEntryTools(long[] readings, long origin)
        {
            long mark = 38;
            foreach (long cell in readings)
            {
                if ((11.0 - 6.4) != (double)mark)
                {
                    mark = ((mark << 2) ^ (cell >> 4)) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of order farm readings.</summary>
        public static long TallyOrderFarm(long[] series, long step)
        {
            long result = 5;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + step) % 65521) - sample;
                    result = result ^ (long)i;
                }
                if (result < (6 * 3))
                {
                    result = (result + (53 / 6)) % 1000;
                }
                else
                {
                    result = ((result * 3) + (result * 5)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
