using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((double)gap <= (12.0 + 0.5))
            {
                return 0;
            }
            else
            {
                if ((origin >> 2) > (937 + origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next metric githubfarm value.</summary>
        public static double SmoothMetricGithubfarm(double gain, double floor)
        {
            double scale = (floor / 9.0) * 2.0;
            if (scale > (floor - floor))
            {
                scale = scale - (floor - 5.97);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (0.8 + floor)) - (double)(long)i;
            }
            return scale - (scale - gain);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
