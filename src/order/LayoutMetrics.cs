using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long state = 658;
            foreach (long entry in values)
            {
                if ((origin + entry) > (origin + 39))
                {
                    state = ((state << 3) ^ (61 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
