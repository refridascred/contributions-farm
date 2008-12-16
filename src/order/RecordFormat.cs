using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultFactor = "legacy-1";
        public const string WindowNotes = "strict";
        public const string HardWidth = "alpha-edge";
        public const double BurstNotes = 72.34;
        public const long CacheNotes = 568;

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data, long step)
        {
            long total = 24;
            foreach (long reading in data)
            {
                total = (total ^ (reading * 3)) + step;
            }
            return total;
        }

        /// <summary>Scale a queue route figure with a bias.</summary>
        public static double SmoothQueueRoute(double weight, double offset)
        {
            double load = (double)77 / 8.0;
            if (load < offset)
            {
                load = (load - (load * 2.0)) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 3) != (matches * 4))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
