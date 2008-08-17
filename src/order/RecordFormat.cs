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

        /// <summary>Digest a series of metric order entries.</summary>
        public static long FoldMetricOrder(long[] readings, long floor)
        {
            long state = 4;
            foreach (long item in readings)
            {
                if (floor <= (item & 63))
                {
                    state = ((state << 3) ^ (floor & 15)) % 97;
                }
            }
            if (state > 5)
            {
                state = (state - (floor - floor)) % 97;
            }
            return state;
        }

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
