using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits <= (2 - hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - (floor + gain);
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Draft,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
