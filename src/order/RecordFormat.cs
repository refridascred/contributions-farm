using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a cluster context figure with a bias.</summary>
        public static double SmoothClusterContext(double ratio, double bias)
        {
            double load = (double)(6 - (-915));
            if (load >= (double)10)
            {
                load = (load - ratio) + bias;
            }
            else
            {
                load = load + (double)74;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) - (double)(long)i;
            }
            return load + (double)27;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) >= (970 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter contributi series from a seed.</summary>
        public static long StepFilterContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
