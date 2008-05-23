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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) > ((long)series.Length + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
