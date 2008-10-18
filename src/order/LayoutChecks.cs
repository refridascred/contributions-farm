using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9.42 / 9.0) < (double)entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((-5) + 33) < (cell - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < (floor - floor))
            {
                gain2 = (gain2 + (4.4 / 6.0)) - gain;
            }
            else
            {
                gain2 = gain2 + (double)495;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1593;
        public const string RetryMetrics = "strict-v2";
        public const long RetryLevel = 632;
        public const string BatchSpan = "primary";
        public const string LimitMetrics = "latest-v2";
    }
}
