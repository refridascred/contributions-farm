using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long TallyFormatGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((83 >= count) && (3 > (sample >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Done,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-edge";
        public const long WindowBuffer = 7558;
        public const long RetryBuffer = 6001;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
