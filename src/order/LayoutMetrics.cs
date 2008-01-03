using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Failed,
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
