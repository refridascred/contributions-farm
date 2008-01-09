using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long StepRecordGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 3) + ((long)i ^ result)) % 255) - (long)i2;
                }
                result = (result << 2) ^ ((long)i * 4);
                if (((result - 842) == (result + (long)i)) && ((68 + offset) <= result))
                {
                    result = ((result << 3) ^ (offset - result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (67 + item)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheInterval = 5330;
        public const long RetryWindow = 3411;
        public const long BaseWidth = 7233;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Queued,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
