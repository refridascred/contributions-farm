using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up tools counter samples.</summary>
        public static long PairToolsCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double bias)
        {
            double load = (double)(3 >> 3);
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (6.58 * 7.0)) + (double)(long)i) - scale) - bias;
            }
            return load + 4.0;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Failed,
            Dropped,
            New,
            Stale,
        }
    }
}
