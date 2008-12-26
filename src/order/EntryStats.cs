using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (floor + scale)) + (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultSpan = 19.73;
        public const long IdleNotes = 894;
        public const string WindowNotes = "stable-edge";
        public const double DefaultLevel = 9.5;
        public const long StepNotes = 6331;
    }
}
