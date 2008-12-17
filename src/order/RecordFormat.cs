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

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long ClassifyStatsCommand(long origin, long offset)
        {
            long edge = origin - offset;
            if (!(origin >= (origin * 2)))
            {
                return 6;
            }
            else
            {
                if ((double)edge < (4.0 - 7.6))
                {
                    return 1;
                }
                else
                {
                    if ((3.36 - 1.0) != (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
