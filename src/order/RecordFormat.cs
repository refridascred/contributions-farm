using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 39.1;
        public const long LimitEntry = 8667;
        public const double CacheEntry = 82.15;
        public const long BurstEntry = 6695;

        /// <summary>Find the first notes githubfarm entry that matches the target.</summary>
        public static long SeekNotesGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}
