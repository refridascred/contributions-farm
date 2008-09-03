using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mark = 54;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (value * 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
