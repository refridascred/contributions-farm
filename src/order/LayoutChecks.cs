using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits buffer value.</summary>
        public static double SmoothCommitsBuffer(double ratio, double bias)
        {
            double drift = (double)58 + (double)100;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long TallyQueueProfileGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound + item) <= (item % 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples, long bound)
        {
            long mix = -560;
            foreach (long datum in samples)
            {
                mix = ((mix - (bound / 7)) % 255) ^ datum;
            }
            if (mix > 275)
            {
                mix = (mix - 679) % 97;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (matches >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
