using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long origin)
        {
            long total = -5;
            foreach (long reading in levels)
            {
                total = total - reading;
                if ((((long)levels.Length - total) >= 88) && ((total / 7) > origin))
                {
                    total = (total + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5768;
        public const long BaseSize = 8416;
        public const long LimitGithubfarm = 3363;
        public const long BurstScore = 1489;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
