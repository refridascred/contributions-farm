using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double span)
        {
            double scale2 = scale - span;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 - scale2;
        }

        /// <summary>Roll a session filter counter forward.</summary>
        public static long SeriesSessionFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit < (limit << 3))
                {
                    state = state ^ (limit ^ limit);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
