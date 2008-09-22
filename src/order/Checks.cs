using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const double RetryBudget = 16.87;
        public const long IdleProfile = 3339;
        public const long MaxProfile = 9205;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 465;
            foreach (long entry in series)
            {
                mix = mix + (entry - (long)series.Length);
                if (mix > (mix ^ entry))
                {
                    mix = mix - mix;
                }
                if (((-3) - mix) < (mix / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Synced,
        }
    }
}
