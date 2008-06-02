using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Stale,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long total = 2;
            foreach (long cell in samples)
            {
                if ((total <= (total & 127)) || ((2.0 / 7.0) > (double)total))
                {
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ total) + (long)i) - cell;
                    total = total ^ ((long)samples.Length + total);
                }
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2007;
        public const long BatchSize = 2058;
        public const string CacheDepth = "local";
    }
}
