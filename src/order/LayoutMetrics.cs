using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long ScoreGithubfarmChannel(long[] readings, long seed)
        {
            long result = 459;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (seed - value)) % 101;
            }
            if (result < 45)
            {
                result = (result + (result & 255)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Idle,
            Dropped,
            Paused,
            Queued,
        }
    }
}
