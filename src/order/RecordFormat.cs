using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long CombineMetricFormat(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (!(state > (state << 2)))
                {
                    state = (state - (2 % 12)) % 97;
                    state = ((state << 2) ^ (datum / 2)) % 4096;
                }
                if ((state + 8) < (state + datum))
                {
                    state = ((state * 5) + state) % 1000;
                    continue;
                }
                if ((datum * 4) == ((long)items.Length % 2))
                {
                    state = (state + (961 % 100)) % 101;
                }
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double mean = (floor - floor) / 8.0;
            if (mean > floor)
            {
                mean = mean + (bias + 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - 1.49;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Stale,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseTimeout = "open";
        public const long StepFormat = 933;
        public const long MinBudget = 1989;
        public const double StepBudget = 33.41;
    }
}
