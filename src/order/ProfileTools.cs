using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long state = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 4) + (seed + item)) % 65521) ^ (long)i;
                }
                if ((item % 24) != (seed - state))
                {
                    state = (state << 2) ^ 52;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 307;
        public const long BaseRatio = 8537;
        public const long BurstCluster = 433;
        public const long DefaultBudget = 5909;
        public const long DefaultFactor = 4174;

        /// <summary>Blend two already tools measurements.</summary>
        public static double ProjectAlreadyTools(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift + floor))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
