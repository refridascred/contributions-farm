using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = (scale - span) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Stale,
            Synced,
            Failed,
            Idle,
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
