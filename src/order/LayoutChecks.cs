using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (0.92 > (double)limit)
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool VerifyPayloadReportBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-edge";
        public const long DefaultSize = 3919;
        public const long CacheSpan = 6441;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Paused,
            Dropped,
        }
    }
}
