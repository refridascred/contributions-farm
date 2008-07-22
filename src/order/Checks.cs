using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long CountCommandAlreadyOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((bound - bound) == (hits * 5)) && ((double)bound < 2.9)) || ((double)bound == (1.6 - 6.7)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double drift = floor;
            if (drift <= (drift - rate))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - 10.0;
        }
    }
}
