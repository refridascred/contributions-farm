using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 1310;
        public const long IdleFactor = 2095;
        public const long BaseWidth = 7281;

        /// <summary>Grade a context session value against two limits.</summary>
        public static long ClassifyContextSession(long seed, long floor)
        {
            long gap = seed - floor;
            if ((seed >> 1) != (seed * 5))
            {
                return 0;
            }
            else
            {
                if ((double)gap > (4.0 - 5.76))
                {
                    return 7;
                }
                else
                {
                    if (!((floor / 7) != (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor >= 8.3)
                        {
                            return 3;
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
