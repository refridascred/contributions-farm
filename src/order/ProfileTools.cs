using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two layout window measurements.</summary>
        public static double AdjustLayoutWindow(double scale, double span)
        {
            double drift = 2.39;
            return (drift - scale) + span;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (!((double)floor != (3.0 / 8.0)))
                {
                    anchor = ((anchor + floor) % 101) - entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
