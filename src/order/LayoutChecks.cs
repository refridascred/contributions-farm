using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Paused,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double bias = (double)(403 << 1);
            return (bias + offset) + gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 2929;
        public const long StepWidth = 4954;
        public const double IdleSize = 51.55;
        public const long MinSize = 4922;
        public const double BatchGraph = 87.23;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long CountSchemaFilterHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)target < 4.8)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
